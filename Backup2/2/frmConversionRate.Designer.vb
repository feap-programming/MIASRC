<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConversionRate
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
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.ddCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpEffectivityDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.seRate = New Telerik.WinControls.UI.RadSpinEditor()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.btnAdd)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.ddCurrency)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.dtpEffectivityDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.seRate)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(640, 100)
        Me.RadPanel1.TabIndex = 2
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(397, 60)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 24)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(42, 14)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(53, 18)
        Me.RadLabel4.TabIndex = 8
        Me.RadLabel4.Text = "Currency:"
        '
        'ddCurrency
        '
        Me.ddCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem4.Text = "JPY"
        RadListDataItem5.Text = "PHP"
        RadListDataItem6.Text = "USD"
        Me.ddCurrency.Items.Add(RadListDataItem4)
        Me.ddCurrency.Items.Add(RadListDataItem5)
        Me.ddCurrency.Items.Add(RadListDataItem6)
        Me.ddCurrency.Location = New System.Drawing.Point(101, 12)
        Me.ddCurrency.Name = "ddCurrency"
        Me.ddCurrency.Size = New System.Drawing.Size(100, 20)
        Me.ddCurrency.TabIndex = 2
        Me.ddCurrency.Text = "JPY"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 66)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(83, 18)
        Me.RadLabel3.TabIndex = 6
        Me.RadLabel3.Text = "Effectivity Date:"
        '
        'dtpEffectivityDate
        '
        Me.dtpEffectivityDate.Location = New System.Drawing.Point(101, 64)
        Me.dtpEffectivityDate.Name = "dtpEffectivityDate"
        Me.dtpEffectivityDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpEffectivityDate.TabIndex = 3
        Me.dtpEffectivityDate.TabStop = False
        Me.dtpEffectivityDate.Text = "Wednesday, October 23, 2019"
        Me.dtpEffectivityDate.Value = New Date(2019, 10, 23, 16, 5, 47, 422)
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(64, 40)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel2.TabIndex = 4
        Me.RadLabel2.Text = "Rate:"
        '
        'seRate
        '
        Me.seRate.DecimalPlaces = 5
        Me.seRate.Location = New System.Drawing.Point(101, 38)
        Me.seRate.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seRate.Name = "seRate"
        Me.seRate.ShowUpDownButtons = False
        Me.seRate.Size = New System.Drawing.Size(100, 20)
        Me.seRate.TabIndex = 1
        Me.seRate.ThousandsSeparator = True
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 100)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(640, 410)
        Me.gvData.TabIndex = 3
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(640, 26)
        Me.RadStatusStrip1.TabIndex = 4
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Number of Record(s)"
        Me.RadLabelElement1.TextWrap = True
        '
        'leCountRec
        '
        Me.leCountRec.Name = "leCountRec"
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, False)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        '
        'FrmConversionRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 536)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConversionRate"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversion Rate"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpEffectivityDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seRate As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
End Class

