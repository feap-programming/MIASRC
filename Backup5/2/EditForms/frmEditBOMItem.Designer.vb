<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditBOMItem
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
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTitle = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtApprovedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCheckedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPreparedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpImplemDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpRevDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpEstDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRefNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDocuNo = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtApprovedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPreparedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpImplemDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRevDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEstDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocuNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(18, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(19, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.Visible = False
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(139, 21)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(371, 20)
        Me.txtTitle.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(75, 23)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(58, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "BOM Title:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(279, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(154, 280)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtApprovedBy)
        Me.RadPanel1.Controls.Add(Me.txtCheckedBy)
        Me.RadPanel1.Controls.Add(Me.txtPreparedBy)
        Me.RadPanel1.Controls.Add(Me.RadLabel9)
        Me.RadPanel1.Controls.Add(Me.RadLabel8)
        Me.RadPanel1.Controls.Add(Me.RadLabel7)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.dtpImplemDate)
        Me.RadPanel1.Controls.Add(Me.dtpRevDate)
        Me.RadPanel1.Controls.Add(Me.dtpEstDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.txtRefNo)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.txtDocuNo)
        Me.RadPanel1.Controls.Add(Me.txtTitle)
        Me.RadPanel1.Controls.Add(Me.btnCancel)
        Me.RadPanel1.Controls.Add(Me.txtID)
        Me.RadPanel1.Controls.Add(Me.btnUpdate)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(539, 325)
        Me.RadPanel1.TabIndex = 35
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtApprovedBy
        '
        Me.txtApprovedBy.Location = New System.Drawing.Point(139, 229)
        Me.txtApprovedBy.Name = "txtApprovedBy"
        Me.txtApprovedBy.Size = New System.Drawing.Size(371, 20)
        Me.txtApprovedBy.TabIndex = 8
        '
        'txtCheckedBy
        '
        Me.txtCheckedBy.Location = New System.Drawing.Point(139, 203)
        Me.txtCheckedBy.Name = "txtCheckedBy"
        Me.txtCheckedBy.Size = New System.Drawing.Size(371, 20)
        Me.txtCheckedBy.TabIndex = 7
        '
        'txtPreparedBy
        '
        Me.txtPreparedBy.Location = New System.Drawing.Point(139, 177)
        Me.txtPreparedBy.Name = "txtPreparedBy"
        Me.txtPreparedBy.Size = New System.Drawing.Size(371, 20)
        Me.txtPreparedBy.TabIndex = 6
        '
        'RadLabel9
        '
        Me.RadLabel9.Location = New System.Drawing.Point(60, 231)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel9.TabIndex = 50
        Me.RadLabel9.Text = "Approved By:"
        '
        'RadLabel8
        '
        Me.RadLabel8.Location = New System.Drawing.Point(66, 205)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(67, 18)
        Me.RadLabel8.TabIndex = 49
        Me.RadLabel8.Text = "Checked By:"
        '
        'RadLabel7
        '
        Me.RadLabel7.Location = New System.Drawing.Point(64, 179)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(69, 18)
        Me.RadLabel7.TabIndex = 48
        Me.RadLabel7.Text = "Prepared By:"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(18, 153)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(115, 18)
        Me.RadLabel6.TabIndex = 44
        Me.RadLabel6.Text = "Implementation Date:"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(60, 127)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel5.TabIndex = 43
        Me.RadLabel5.Text = "Revised Date:"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(42, 101)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(91, 18)
        Me.RadLabel4.TabIndex = 42
        Me.RadLabel4.Text = "Established Date:"
        '
        'dtpImplemDate
        '
        Me.dtpImplemDate.Location = New System.Drawing.Point(139, 151)
        Me.dtpImplemDate.Name = "dtpImplemDate"
        Me.dtpImplemDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpImplemDate.TabIndex = 5
        Me.dtpImplemDate.TabStop = False
        Me.dtpImplemDate.Text = "Tuesday, April 30, 2019"
        Me.dtpImplemDate.Value = New Date(2019, 4, 30, 8, 24, 24, 877)
        '
        'dtpRevDate
        '
        Me.dtpRevDate.Location = New System.Drawing.Point(139, 125)
        Me.dtpRevDate.Name = "dtpRevDate"
        Me.dtpRevDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpRevDate.TabIndex = 4
        Me.dtpRevDate.TabStop = False
        Me.dtpRevDate.Text = "Tuesday, April 30, 2019"
        Me.dtpRevDate.Value = New Date(2019, 4, 30, 8, 24, 24, 877)
        '
        'dtpEstDate
        '
        Me.dtpEstDate.Location = New System.Drawing.Point(139, 99)
        Me.dtpEstDate.Name = "dtpEstDate"
        Me.dtpEstDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpEstDate.TabIndex = 3
        Me.dtpEstDate.TabStop = False
        Me.dtpEstDate.Text = "Tuesday, April 30, 2019"
        Me.dtpEstDate.Value = New Date(2019, 4, 30, 8, 24, 24, 877)
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(54, 75)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(79, 18)
        Me.RadLabel3.TabIndex = 41
        Me.RadLabel3.Text = "Reference No.:"
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(139, 73)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(164, 20)
        Me.txtRefNo.TabIndex = 2
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(52, 49)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(81, 18)
        Me.RadLabel2.TabIndex = 38
        Me.RadLabel2.Text = "Document No.:"
        '
        'txtDocuNo
        '
        Me.txtDocuNo.Location = New System.Drawing.Point(139, 47)
        Me.txtDocuNo.Name = "txtDocuNo"
        Me.txtDocuNo.Size = New System.Drawing.Size(164, 20)
        Me.txtDocuNo.TabIndex = 1
        '
        'FrmEditBOMItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 325)
        Me.Controls.Add(Me.RadPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEditBOMItem"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit BOM Item"
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtApprovedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPreparedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpImplemDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRevDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEstDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocuNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtTitle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpImplemDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpRevDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpEstDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRefNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDocuNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtApprovedBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCheckedBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPreparedBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
End Class

