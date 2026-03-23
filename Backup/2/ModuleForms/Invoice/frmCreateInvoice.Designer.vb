<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCreateInvoice
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
        Dim TableViewDefinition10 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition11 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition12 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition13 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition14 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition15 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition16 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition17 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition18 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem15 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem16 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem17 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem18 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem19 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreateInvoice))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.cbATACustomer = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbATDManila = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbATDFEAP = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbETDManila = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbETDFEAP = New Telerik.WinControls.UI.RadCheckBox()
        Me.mcbFreightCondition = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbShippedTo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbBIRReference = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbApprovedBy = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbNotedBy = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbCheckedBy = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbPreparedBy = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbSoldTo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbCustomer = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.numInvoiceNo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.drpActivity = New Telerik.WinControls.UI.RadDropDownList()
        Me.drpInvoiceUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.drpShipVia = New Telerik.WinControls.UI.RadDropDownList()
        Me.drpCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblCurrency = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.numForexUSD = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numForex = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblApprovedBy = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblForexUSD = New Telerik.WinControls.UI.RadLabel()
        Me.lblNotedBy = New Telerik.WinControls.UI.RadLabel()
        Me.lblForex = New Telerik.WinControls.UI.RadLabel()
        Me.lblCheckedBy = New Telerik.WinControls.UI.RadLabel()
        Me.lblShippedTo = New Telerik.WinControls.UI.RadLabel()
        Me.lblPreparedBy = New Telerik.WinControls.UI.RadLabel()
        Me.lblSoldTo = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTerms = New Telerik.WinControls.UI.RadTextBox()
        Me.lblRemarks = New Telerik.WinControls.UI.RadLabel()
        Me.txtDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPCNo = New Telerik.WinControls.UI.RadTextBox()
        Me.bllTerms = New Telerik.WinControls.UI.RadLabel()
        Me.lblDescription = New Telerik.WinControls.UI.RadLabel()
        Me.txtPONo = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPCNo = New Telerik.WinControls.UI.RadLabel()
        Me.txtNoOfPackages = New Telerik.WinControls.UI.RadTextBox()
        Me.txtFreightTerms = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDRNo = New Telerik.WinControls.UI.RadTextBox()
        Me.lblInvoiceUOM = New Telerik.WinControls.UI.RadLabel()
        Me.lblPONo = New Telerik.WinControls.UI.RadLabel()
        Me.lblNoOfPackages = New Telerik.WinControls.UI.RadLabel()
        Me.lblActivity = New Telerik.WinControls.UI.RadLabel()
        Me.lblFreightTerms = New Telerik.WinControls.UI.RadLabel()
        Me.lblInvoiceNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblShipVia = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.lblDRNo = New Telerik.WinControls.UI.RadLabel()
        Me.dtSailingOnOrAbout = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblSailingOnOrAbout = New Telerik.WinControls.UI.RadLabel()
        Me.dtATACustomer = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATACustomer = New Telerik.WinControls.UI.RadLabel()
        Me.dtATDManila = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATDManila = New Telerik.WinControls.UI.RadLabel()
        Me.lblETDManila = New Telerik.WinControls.UI.RadLabel()
        Me.dtATDFEAP = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtETDManila = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtInvoiceDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtETDFEAP = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblInvoiceDate = New Telerik.WinControls.UI.RadLabel()
        Me.lblATDFEAP = New Telerik.WinControls.UI.RadLabel()
        Me.lblETDFEAP = New Telerik.WinControls.UI.RadLabel()
        Me.btnCreateInvoice = New Telerik.WinControls.UI.RadButton()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.cbATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbETDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFreightCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFreightCondition.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFreightCondition.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShippedTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShippedTo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShippedTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbBIRReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbBIRReference.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbBIRReference.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbApprovedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbApprovedBy.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbApprovedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbNotedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbNotedBy.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbNotedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCheckedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCheckedBy.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCheckedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPreparedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPreparedBy.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPreparedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbSoldTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbSoldTo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbSoldTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpInvoiceUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpShipVia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numForexUSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numForex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblApprovedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblForexUSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNotedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblForex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCheckedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblShippedTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPreparedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSoldTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPCNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bllTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPONo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPCNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOfPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFreightTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDRNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInvoiceUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPONo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoOfPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFreightTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblShipVia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDRNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSailingOnOrAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSailingOnOrAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCreateInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panel.Controls.Add(Me.cbATACustomer)
        Me.panel.Controls.Add(Me.cbATDManila)
        Me.panel.Controls.Add(Me.cbATDFEAP)
        Me.panel.Controls.Add(Me.cbETDManila)
        Me.panel.Controls.Add(Me.cbETDFEAP)
        Me.panel.Controls.Add(Me.mcbFreightCondition)
        Me.panel.Controls.Add(Me.mcbShippedTo)
        Me.panel.Controls.Add(Me.mcbBIRReference)
        Me.panel.Controls.Add(Me.mcbApprovedBy)
        Me.panel.Controls.Add(Me.mcbNotedBy)
        Me.panel.Controls.Add(Me.mcbCheckedBy)
        Me.panel.Controls.Add(Me.mcbPreparedBy)
        Me.panel.Controls.Add(Me.mcbSoldTo)
        Me.panel.Controls.Add(Me.mcbCustomer)
        Me.panel.Controls.Add(Me.numInvoiceNo)
        Me.panel.Controls.Add(Me.drpActivity)
        Me.panel.Controls.Add(Me.drpInvoiceUOM)
        Me.panel.Controls.Add(Me.drpShipVia)
        Me.panel.Controls.Add(Me.drpCurrency)
        Me.panel.Controls.Add(Me.lblCurrency)
        Me.panel.Controls.Add(Me.RadLabel5)
        Me.panel.Controls.Add(Me.numForexUSD)
        Me.panel.Controls.Add(Me.numForex)
        Me.panel.Controls.Add(Me.lblApprovedBy)
        Me.panel.Controls.Add(Me.RadLabel1)
        Me.panel.Controls.Add(Me.lblForexUSD)
        Me.panel.Controls.Add(Me.lblNotedBy)
        Me.panel.Controls.Add(Me.lblForex)
        Me.panel.Controls.Add(Me.lblCheckedBy)
        Me.panel.Controls.Add(Me.lblShippedTo)
        Me.panel.Controls.Add(Me.lblPreparedBy)
        Me.panel.Controls.Add(Me.lblSoldTo)
        Me.panel.Controls.Add(Me.txtRemarks)
        Me.panel.Controls.Add(Me.txtTerms)
        Me.panel.Controls.Add(Me.lblRemarks)
        Me.panel.Controls.Add(Me.txtDescription)
        Me.panel.Controls.Add(Me.txtPCNo)
        Me.panel.Controls.Add(Me.bllTerms)
        Me.panel.Controls.Add(Me.lblDescription)
        Me.panel.Controls.Add(Me.txtPONo)
        Me.panel.Controls.Add(Me.lblPCNo)
        Me.panel.Controls.Add(Me.txtNoOfPackages)
        Me.panel.Controls.Add(Me.txtFreightTerms)
        Me.panel.Controls.Add(Me.txtDRNo)
        Me.panel.Controls.Add(Me.lblInvoiceUOM)
        Me.panel.Controls.Add(Me.lblPONo)
        Me.panel.Controls.Add(Me.lblNoOfPackages)
        Me.panel.Controls.Add(Me.lblActivity)
        Me.panel.Controls.Add(Me.lblFreightTerms)
        Me.panel.Controls.Add(Me.lblInvoiceNo)
        Me.panel.Controls.Add(Me.lblShipVia)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.lblDRNo)
        Me.panel.Controls.Add(Me.dtSailingOnOrAbout)
        Me.panel.Controls.Add(Me.lblSailingOnOrAbout)
        Me.panel.Controls.Add(Me.dtATACustomer)
        Me.panel.Controls.Add(Me.lblATACustomer)
        Me.panel.Controls.Add(Me.dtATDManila)
        Me.panel.Controls.Add(Me.lblATDManila)
        Me.panel.Controls.Add(Me.lblETDManila)
        Me.panel.Controls.Add(Me.dtATDFEAP)
        Me.panel.Controls.Add(Me.dtETDManila)
        Me.panel.Controls.Add(Me.dtInvoiceDate)
        Me.panel.Controls.Add(Me.dtETDFEAP)
        Me.panel.Controls.Add(Me.lblInvoiceDate)
        Me.panel.Controls.Add(Me.lblATDFEAP)
        Me.panel.Controls.Add(Me.lblETDFEAP)
        Me.panel.Controls.Add(Me.btnCreateInvoice)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(752, 390)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'cbATACustomer
        '
        Me.cbATACustomer.Location = New System.Drawing.Point(205, 272)
        Me.cbATACustomer.Name = "cbATACustomer"
        Me.cbATACustomer.Size = New System.Drawing.Size(15, 15)
        Me.cbATACustomer.TabIndex = 10
        '
        'cbATDManila
        '
        Me.cbATDManila.Location = New System.Drawing.Point(205, 246)
        Me.cbATDManila.Name = "cbATDManila"
        Me.cbATDManila.Size = New System.Drawing.Size(15, 15)
        Me.cbATDManila.TabIndex = 9
        '
        'cbATDFEAP
        '
        Me.cbATDFEAP.Location = New System.Drawing.Point(205, 220)
        Me.cbATDFEAP.Name = "cbATDFEAP"
        Me.cbATDFEAP.Size = New System.Drawing.Size(15, 15)
        Me.cbATDFEAP.TabIndex = 8
        '
        'cbETDManila
        '
        Me.cbETDManila.Location = New System.Drawing.Point(205, 194)
        Me.cbETDManila.Name = "cbETDManila"
        Me.cbETDManila.Size = New System.Drawing.Size(15, 15)
        Me.cbETDManila.TabIndex = 7
        '
        'cbETDFEAP
        '
        Me.cbETDFEAP.Location = New System.Drawing.Point(205, 168)
        Me.cbETDFEAP.Name = "cbETDFEAP"
        Me.cbETDFEAP.Size = New System.Drawing.Size(15, 15)
        Me.cbETDFEAP.TabIndex = 6
        '
        'mcbFreightCondition
        '
        '
        'mcbFreightCondition.NestedRadGridView
        '
        Me.mcbFreightCondition.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbFreightCondition.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbFreightCondition.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbFreightCondition.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbFreightCondition.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbFreightCondition.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbFreightCondition.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbFreightCondition.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbFreightCondition.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbFreightCondition.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition10
        Me.mcbFreightCondition.EditorControl.Name = "NestedRadGridView"
        Me.mcbFreightCondition.EditorControl.ReadOnly = True
        Me.mcbFreightCondition.EditorControl.ShowGroupPanel = False
        Me.mcbFreightCondition.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbFreightCondition.EditorControl.TabIndex = 0
        Me.mcbFreightCondition.Location = New System.Drawing.Point(350, 324)
        Me.mcbFreightCondition.Name = "mcbFreightCondition"
        Me.mcbFreightCondition.Size = New System.Drawing.Size(120, 20)
        Me.mcbFreightCondition.TabIndex = 23
        Me.mcbFreightCondition.TabStop = False
        '
        'mcbShippedTo
        '
        '
        'mcbShippedTo.NestedRadGridView
        '
        Me.mcbShippedTo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbShippedTo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbShippedTo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbShippedTo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbShippedTo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbShippedTo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbShippedTo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbShippedTo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbShippedTo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbShippedTo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition11
        Me.mcbShippedTo.EditorControl.Name = "NestedRadGridView"
        Me.mcbShippedTo.EditorControl.ReadOnly = True
        Me.mcbShippedTo.EditorControl.ShowGroupPanel = False
        Me.mcbShippedTo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbShippedTo.EditorControl.TabIndex = 0
        Me.mcbShippedTo.Location = New System.Drawing.Point(350, 90)
        Me.mcbShippedTo.Name = "mcbShippedTo"
        Me.mcbShippedTo.Size = New System.Drawing.Size(120, 20)
        Me.mcbShippedTo.TabIndex = 15
        Me.mcbShippedTo.TabStop = False
        '
        'mcbBIRReference
        '
        '
        'mcbBIRReference.NestedRadGridView
        '
        Me.mcbBIRReference.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbBIRReference.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbBIRReference.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbBIRReference.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbBIRReference.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbBIRReference.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbBIRReference.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbBIRReference.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbBIRReference.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbBIRReference.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition12
        Me.mcbBIRReference.EditorControl.Name = "NestedRadGridView"
        Me.mcbBIRReference.EditorControl.ReadOnly = True
        Me.mcbBIRReference.EditorControl.ShowGroupPanel = False
        Me.mcbBIRReference.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbBIRReference.EditorControl.TabIndex = 0
        Me.mcbBIRReference.Location = New System.Drawing.Point(600, 194)
        Me.mcbBIRReference.Name = "mcbBIRReference"
        Me.mcbBIRReference.Size = New System.Drawing.Size(120, 20)
        Me.mcbBIRReference.TabIndex = 31
        Me.mcbBIRReference.TabStop = False
        '
        'mcbApprovedBy
        '
        '
        'mcbApprovedBy.NestedRadGridView
        '
        Me.mcbApprovedBy.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbApprovedBy.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbApprovedBy.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbApprovedBy.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbApprovedBy.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbApprovedBy.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition13
        Me.mcbApprovedBy.EditorControl.Name = "NestedRadGridView"
        Me.mcbApprovedBy.EditorControl.ReadOnly = True
        Me.mcbApprovedBy.EditorControl.ShowGroupPanel = False
        Me.mcbApprovedBy.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbApprovedBy.EditorControl.TabIndex = 0
        Me.mcbApprovedBy.Location = New System.Drawing.Point(600, 168)
        Me.mcbApprovedBy.Name = "mcbApprovedBy"
        Me.mcbApprovedBy.Size = New System.Drawing.Size(120, 20)
        Me.mcbApprovedBy.TabIndex = 30
        Me.mcbApprovedBy.TabStop = False
        '
        'mcbNotedBy
        '
        '
        'mcbNotedBy.NestedRadGridView
        '
        Me.mcbNotedBy.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbNotedBy.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbNotedBy.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbNotedBy.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbNotedBy.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbNotedBy.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbNotedBy.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbNotedBy.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbNotedBy.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbNotedBy.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition14
        Me.mcbNotedBy.EditorControl.Name = "NestedRadGridView"
        Me.mcbNotedBy.EditorControl.ReadOnly = True
        Me.mcbNotedBy.EditorControl.ShowGroupPanel = False
        Me.mcbNotedBy.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbNotedBy.EditorControl.TabIndex = 0
        Me.mcbNotedBy.Location = New System.Drawing.Point(600, 142)
        Me.mcbNotedBy.Name = "mcbNotedBy"
        Me.mcbNotedBy.Size = New System.Drawing.Size(120, 20)
        Me.mcbNotedBy.TabIndex = 29
        Me.mcbNotedBy.TabStop = False
        '
        'mcbCheckedBy
        '
        '
        'mcbCheckedBy.NestedRadGridView
        '
        Me.mcbCheckedBy.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbCheckedBy.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbCheckedBy.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbCheckedBy.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbCheckedBy.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbCheckedBy.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition15
        Me.mcbCheckedBy.EditorControl.Name = "NestedRadGridView"
        Me.mcbCheckedBy.EditorControl.ReadOnly = True
        Me.mcbCheckedBy.EditorControl.ShowGroupPanel = False
        Me.mcbCheckedBy.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbCheckedBy.EditorControl.TabIndex = 0
        Me.mcbCheckedBy.Location = New System.Drawing.Point(600, 116)
        Me.mcbCheckedBy.Name = "mcbCheckedBy"
        Me.mcbCheckedBy.Size = New System.Drawing.Size(120, 20)
        Me.mcbCheckedBy.TabIndex = 28
        Me.mcbCheckedBy.TabStop = False
        '
        'mcbPreparedBy
        '
        '
        'mcbPreparedBy.NestedRadGridView
        '
        Me.mcbPreparedBy.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbPreparedBy.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbPreparedBy.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbPreparedBy.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbPreparedBy.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbPreparedBy.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbPreparedBy.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbPreparedBy.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbPreparedBy.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbPreparedBy.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition16
        Me.mcbPreparedBy.EditorControl.Name = "NestedRadGridView"
        Me.mcbPreparedBy.EditorControl.ReadOnly = True
        Me.mcbPreparedBy.EditorControl.ShowGroupPanel = False
        Me.mcbPreparedBy.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbPreparedBy.EditorControl.TabIndex = 0
        Me.mcbPreparedBy.Location = New System.Drawing.Point(600, 90)
        Me.mcbPreparedBy.Name = "mcbPreparedBy"
        Me.mcbPreparedBy.Size = New System.Drawing.Size(120, 20)
        Me.mcbPreparedBy.TabIndex = 27
        Me.mcbPreparedBy.TabStop = False
        '
        'mcbSoldTo
        '
        '
        'mcbSoldTo.NestedRadGridView
        '
        Me.mcbSoldTo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbSoldTo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbSoldTo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbSoldTo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbSoldTo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbSoldTo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbSoldTo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbSoldTo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbSoldTo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbSoldTo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition17
        Me.mcbSoldTo.EditorControl.Name = "NestedRadGridView"
        Me.mcbSoldTo.EditorControl.ReadOnly = True
        Me.mcbSoldTo.EditorControl.ShowGroupPanel = False
        Me.mcbSoldTo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbSoldTo.EditorControl.TabIndex = 0
        Me.mcbSoldTo.Location = New System.Drawing.Point(350, 64)
        Me.mcbSoldTo.Name = "mcbSoldTo"
        Me.mcbSoldTo.Size = New System.Drawing.Size(120, 20)
        Me.mcbSoldTo.TabIndex = 14
        Me.mcbSoldTo.TabStop = False
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
        Me.mcbCustomer.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition18
        Me.mcbCustomer.EditorControl.Name = "NestedRadGridView"
        Me.mcbCustomer.EditorControl.ReadOnly = True
        Me.mcbCustomer.EditorControl.ShowGroupPanel = False
        Me.mcbCustomer.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbCustomer.EditorControl.TabIndex = 0
        Me.mcbCustomer.Location = New System.Drawing.Point(100, 38)
        Me.mcbCustomer.Name = "mcbCustomer"
        Me.mcbCustomer.Size = New System.Drawing.Size(120, 20)
        Me.mcbCustomer.TabIndex = 2
        Me.mcbCustomer.TabStop = False
        '
        'numInvoiceNo
        '
        Me.numInvoiceNo.Location = New System.Drawing.Point(100, 12)
        Me.numInvoiceNo.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numInvoiceNo.Name = "numInvoiceNo"
        Me.numInvoiceNo.ShowUpDownButtons = False
        Me.numInvoiceNo.Size = New System.Drawing.Size(120, 20)
        Me.numInvoiceNo.TabIndex = 1
        Me.numInvoiceNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'drpActivity
        '
        Me.drpActivity.DropDownAnimationEnabled = True
        Me.drpActivity.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem15.Text = "SRC"
        RadListDataItem16.Text = "BSS"
        RadListDataItem17.Text = "Warehousing"
        RadListDataItem18.Text = "FFC Manufacturing"
        RadListDataItem19.Text = "Other Activity"
        Me.drpActivity.Items.Add(RadListDataItem15)
        Me.drpActivity.Items.Add(RadListDataItem16)
        Me.drpActivity.Items.Add(RadListDataItem17)
        Me.drpActivity.Items.Add(RadListDataItem18)
        Me.drpActivity.Items.Add(RadListDataItem19)
        Me.drpActivity.Location = New System.Drawing.Point(100, 64)
        Me.drpActivity.Name = "drpActivity"
        Me.drpActivity.Size = New System.Drawing.Size(120, 20)
        Me.drpActivity.TabIndex = 3
        '
        'drpInvoiceUOM
        '
        Me.drpInvoiceUOM.DropDownAnimationEnabled = True
        Me.drpInvoiceUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "PC"
        RadListDataItem2.Text = "KG"
        RadListDataItem3.Text = "M"
        Me.drpInvoiceUOM.Items.Add(RadListDataItem1)
        Me.drpInvoiceUOM.Items.Add(RadListDataItem2)
        Me.drpInvoiceUOM.Items.Add(RadListDataItem3)
        Me.drpInvoiceUOM.Location = New System.Drawing.Point(350, 350)
        Me.drpInvoiceUOM.Name = "drpInvoiceUOM"
        Me.drpInvoiceUOM.Size = New System.Drawing.Size(120, 20)
        Me.drpInvoiceUOM.TabIndex = 24
        '
        'drpShipVia
        '
        Me.drpShipVia.DropDownAnimationEnabled = True
        Me.drpShipVia.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem5.Text = "AIRFREIGHT"
        RadListDataItem6.Text = "SEAFREIGHT"
        Me.drpShipVia.Items.Add(RadListDataItem4)
        Me.drpShipVia.Items.Add(RadListDataItem5)
        Me.drpShipVia.Items.Add(RadListDataItem6)
        Me.drpShipVia.Location = New System.Drawing.Point(350, 246)
        Me.drpShipVia.Name = "drpShipVia"
        Me.drpShipVia.Size = New System.Drawing.Size(120, 20)
        Me.drpShipVia.TabIndex = 20
        '
        'drpCurrency
        '
        Me.drpCurrency.DropDownAnimationEnabled = True
        Me.drpCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem7.Text = "PHP"
        RadListDataItem8.Text = "JPY"
        RadListDataItem9.Text = "USD"
        Me.drpCurrency.Items.Add(RadListDataItem7)
        Me.drpCurrency.Items.Add(RadListDataItem8)
        Me.drpCurrency.Items.Add(RadListDataItem9)
        Me.drpCurrency.Location = New System.Drawing.Point(350, 168)
        Me.drpCurrency.Name = "drpCurrency"
        Me.drpCurrency.Size = New System.Drawing.Size(120, 20)
        Me.drpCurrency.TabIndex = 17
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrency.Location = New System.Drawing.Point(293, 170)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(51, 18)
        Me.lblCurrency.TabIndex = 0
        Me.lblCurrency.Text = "Currency"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(519, 196)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel5.TabIndex = 0
        Me.RadLabel5.Text = "BIR Reference"
        '
        'numForexUSD
        '
        Me.numForexUSD.DecimalPlaces = 4
        Me.numForexUSD.Location = New System.Drawing.Point(350, 220)
        Me.numForexUSD.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numForexUSD.Name = "numForexUSD"
        Me.numForexUSD.ShowUpDownButtons = False
        Me.numForexUSD.Size = New System.Drawing.Size(120, 20)
        Me.numForexUSD.TabIndex = 19
        Me.numForexUSD.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numForex
        '
        Me.numForex.DecimalPlaces = 4
        Me.numForex.Location = New System.Drawing.Point(350, 194)
        Me.numForex.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numForex.Name = "numForex"
        Me.numForex.ShowUpDownButtons = False
        Me.numForex.Size = New System.Drawing.Size(120, 20)
        Me.numForex.TabIndex = 18
        Me.numForex.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblApprovedBy
        '
        Me.lblApprovedBy.Location = New System.Drawing.Point(524, 170)
        Me.lblApprovedBy.Name = "lblApprovedBy"
        Me.lblApprovedBy.Size = New System.Drawing.Size(70, 18)
        Me.lblApprovedBy.TabIndex = 0
        Me.lblApprovedBy.Text = "Approved By"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(251, 326)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(93, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Freight Condition"
        '
        'lblForexUSD
        '
        Me.lblForexUSD.Location = New System.Drawing.Point(279, 222)
        Me.lblForexUSD.Name = "lblForexUSD"
        Me.lblForexUSD.Size = New System.Drawing.Size(65, 18)
        Me.lblForexUSD.TabIndex = 0
        Me.lblForexUSD.Text = "Forex (USD)"
        '
        'lblNotedBy
        '
        Me.lblNotedBy.Location = New System.Drawing.Point(541, 144)
        Me.lblNotedBy.Name = "lblNotedBy"
        Me.lblNotedBy.Size = New System.Drawing.Size(53, 18)
        Me.lblNotedBy.TabIndex = 0
        Me.lblNotedBy.Text = "Noted By"
        '
        'lblForex
        '
        Me.lblForex.Location = New System.Drawing.Point(284, 196)
        Me.lblForex.Name = "lblForex"
        Me.lblForex.Size = New System.Drawing.Size(60, 18)
        Me.lblForex.TabIndex = 0
        Me.lblForex.Text = "Forex (JPY)"
        '
        'lblCheckedBy
        '
        Me.lblCheckedBy.Location = New System.Drawing.Point(530, 118)
        Me.lblCheckedBy.Name = "lblCheckedBy"
        Me.lblCheckedBy.Size = New System.Drawing.Size(64, 18)
        Me.lblCheckedBy.TabIndex = 0
        Me.lblCheckedBy.Text = "Checked By"
        '
        'lblShippedTo
        '
        Me.lblShippedTo.Location = New System.Drawing.Point(281, 92)
        Me.lblShippedTo.Name = "lblShippedTo"
        Me.lblShippedTo.Size = New System.Drawing.Size(63, 18)
        Me.lblShippedTo.TabIndex = 0
        Me.lblShippedTo.Text = "Shipped To"
        '
        'lblPreparedBy
        '
        Me.lblPreparedBy.Location = New System.Drawing.Point(528, 92)
        Me.lblPreparedBy.Name = "lblPreparedBy"
        Me.lblPreparedBy.Size = New System.Drawing.Size(66, 18)
        Me.lblPreparedBy.TabIndex = 0
        Me.lblPreparedBy.Text = "Prepared By"
        '
        'lblSoldTo
        '
        Me.lblSoldTo.Location = New System.Drawing.Point(300, 66)
        Me.lblSoldTo.Name = "lblSoldTo"
        Me.lblSoldTo.Size = New System.Drawing.Size(44, 18)
        Me.lblSoldTo.TabIndex = 0
        Me.lblSoldTo.Text = "Sold To"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(600, 38)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        '
        '
        '
        Me.txtRemarks.RootElement.StretchVertically = True
        Me.txtRemarks.Size = New System.Drawing.Size(120, 46)
        Me.txtRemarks.TabIndex = 26
        '
        'txtTerms
        '
        Me.txtTerms.Location = New System.Drawing.Point(350, 116)
        Me.txtTerms.Multiline = True
        Me.txtTerms.Name = "txtTerms"
        '
        '
        '
        Me.txtTerms.RootElement.StretchVertically = True
        Me.txtTerms.Size = New System.Drawing.Size(120, 46)
        Me.txtTerms.TabIndex = 16
        '
        'lblRemarks
        '
        Me.lblRemarks.Location = New System.Drawing.Point(545, 39)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 18)
        Me.lblRemarks.TabIndex = 0
        Me.lblRemarks.Text = "Remarks"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(100, 90)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        '
        '
        '
        Me.txtDescription.RootElement.StretchVertically = True
        Me.txtDescription.Size = New System.Drawing.Size(120, 46)
        Me.txtDescription.TabIndex = 4
        '
        'txtPCNo
        '
        Me.txtPCNo.Location = New System.Drawing.Point(350, 12)
        Me.txtPCNo.Multiline = True
        Me.txtPCNo.Name = "txtPCNo"
        '
        '
        '
        Me.txtPCNo.RootElement.StretchVertically = True
        Me.txtPCNo.Size = New System.Drawing.Size(120, 46)
        Me.txtPCNo.TabIndex = 13
        '
        'bllTerms
        '
        Me.bllTerms.Location = New System.Drawing.Point(307, 117)
        Me.bllTerms.Name = "bllTerms"
        Me.bllTerms.Size = New System.Drawing.Size(37, 18)
        Me.bllTerms.TabIndex = 0
        Me.bllTerms.Text = "Terms"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(31, 91)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 18)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Description"
        '
        'txtPONo
        '
        Me.txtPONo.Location = New System.Drawing.Point(100, 324)
        Me.txtPONo.Multiline = True
        Me.txtPONo.Name = "txtPONo"
        '
        '
        '
        Me.txtPONo.RootElement.StretchVertically = True
        Me.txtPONo.Size = New System.Drawing.Size(120, 46)
        Me.txtPONo.TabIndex = 12
        '
        'lblPCNo
        '
        Me.lblPCNo.Location = New System.Drawing.Point(306, 13)
        Me.lblPCNo.Name = "lblPCNo"
        Me.lblPCNo.Size = New System.Drawing.Size(38, 18)
        Me.lblPCNo.TabIndex = 0
        Me.lblPCNo.Text = "PC No"
        '
        'txtNoOfPackages
        '
        Me.txtNoOfPackages.Location = New System.Drawing.Point(600, 12)
        Me.txtNoOfPackages.Name = "txtNoOfPackages"
        Me.txtNoOfPackages.Size = New System.Drawing.Size(120, 20)
        Me.txtNoOfPackages.TabIndex = 25
        '
        'txtFreightTerms
        '
        Me.txtFreightTerms.Location = New System.Drawing.Point(350, 298)
        Me.txtFreightTerms.Name = "txtFreightTerms"
        Me.txtFreightTerms.Size = New System.Drawing.Size(120, 20)
        Me.txtFreightTerms.TabIndex = 22
        '
        'txtDRNo
        '
        Me.txtDRNo.Location = New System.Drawing.Point(100, 298)
        Me.txtDRNo.Name = "txtDRNo"
        Me.txtDRNo.Size = New System.Drawing.Size(120, 20)
        Me.txtDRNo.TabIndex = 11
        '
        'lblInvoiceUOM
        '
        Me.lblInvoiceUOM.BackColor = System.Drawing.Color.Transparent
        Me.lblInvoiceUOM.Location = New System.Drawing.Point(273, 352)
        Me.lblInvoiceUOM.Name = "lblInvoiceUOM"
        Me.lblInvoiceUOM.Size = New System.Drawing.Size(71, 18)
        Me.lblInvoiceUOM.TabIndex = 0
        Me.lblInvoiceUOM.Text = "Invoice UOM"
        '
        'lblPONo
        '
        Me.lblPONo.Location = New System.Drawing.Point(55, 327)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(39, 18)
        Me.lblPONo.TabIndex = 0
        Me.lblPONo.Text = "PO No"
        '
        'lblNoOfPackages
        '
        Me.lblNoOfPackages.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfPackages.Location = New System.Drawing.Point(508, 14)
        Me.lblNoOfPackages.Name = "lblNoOfPackages"
        Me.lblNoOfPackages.Size = New System.Drawing.Size(86, 18)
        Me.lblNoOfPackages.TabIndex = 0
        Me.lblNoOfPackages.Text = "No Of Packages"
        '
        'lblActivity
        '
        Me.lblActivity.Location = New System.Drawing.Point(51, 66)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(43, 18)
        Me.lblActivity.TabIndex = 0
        Me.lblActivity.Text = "Activity"
        '
        'lblFreightTerms
        '
        Me.lblFreightTerms.BackColor = System.Drawing.Color.Transparent
        Me.lblFreightTerms.Location = New System.Drawing.Point(269, 300)
        Me.lblFreightTerms.Name = "lblFreightTerms"
        Me.lblFreightTerms.Size = New System.Drawing.Size(75, 18)
        Me.lblFreightTerms.TabIndex = 0
        Me.lblFreightTerms.Text = "Freight Terms"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvoiceNo.Location = New System.Drawing.Point(34, 14)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(60, 18)
        Me.lblInvoiceNo.TabIndex = 0
        Me.lblInvoiceNo.Text = "Invoice No"
        '
        'lblShipVia
        '
        Me.lblShipVia.BackColor = System.Drawing.Color.Transparent
        Me.lblShipVia.Location = New System.Drawing.Point(297, 248)
        Me.lblShipVia.Name = "lblShipVia"
        Me.lblShipVia.Size = New System.Drawing.Size(47, 18)
        Me.lblShipVia.TabIndex = 0
        Me.lblShipVia.Text = "Ship Via"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(39, 40)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'lblDRNo
        '
        Me.lblDRNo.BackColor = System.Drawing.Color.Transparent
        Me.lblDRNo.Location = New System.Drawing.Point(55, 300)
        Me.lblDRNo.Name = "lblDRNo"
        Me.lblDRNo.Size = New System.Drawing.Size(39, 18)
        Me.lblDRNo.TabIndex = 0
        Me.lblDRNo.Text = "DR No"
        '
        'dtSailingOnOrAbout
        '
        Me.dtSailingOnOrAbout.CustomFormat = "MMM dd, yyyy"
        Me.dtSailingOnOrAbout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSailingOnOrAbout.Location = New System.Drawing.Point(350, 272)
        Me.dtSailingOnOrAbout.Name = "dtSailingOnOrAbout"
        Me.dtSailingOnOrAbout.Size = New System.Drawing.Size(120, 20)
        Me.dtSailingOnOrAbout.TabIndex = 21
        Me.dtSailingOnOrAbout.TabStop = False
        Me.dtSailingOnOrAbout.Text = "Aug 25, 2020"
        Me.dtSailingOnOrAbout.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblSailingOnOrAbout
        '
        Me.lblSailingOnOrAbout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSailingOnOrAbout.Location = New System.Drawing.Point(237, 274)
        Me.lblSailingOnOrAbout.Name = "lblSailingOnOrAbout"
        Me.lblSailingOnOrAbout.Size = New System.Drawing.Size(107, 18)
        Me.lblSailingOnOrAbout.TabIndex = 0
        Me.lblSailingOnOrAbout.Text = "Sailing On Or About"
        '
        'dtATACustomer
        '
        Me.dtATACustomer.CustomFormat = "MMM dd, yyyy"
        Me.dtATACustomer.Enabled = False
        Me.dtATACustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATACustomer.Location = New System.Drawing.Point(100, 272)
        Me.dtATACustomer.Name = "dtATACustomer"
        Me.dtATACustomer.Size = New System.Drawing.Size(100, 20)
        Me.dtATACustomer.TabIndex = 10
        Me.dtATACustomer.TabStop = False
        Me.dtATACustomer.Text = "Aug 25, 2020"
        Me.dtATACustomer.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblATACustomer
        '
        Me.lblATACustomer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATACustomer.Location = New System.Drawing.Point(16, 274)
        Me.lblATACustomer.Name = "lblATACustomer"
        Me.lblATACustomer.Size = New System.Drawing.Size(78, 18)
        Me.lblATACustomer.TabIndex = 0
        Me.lblATACustomer.Text = "ATA Customer"
        '
        'dtATDManila
        '
        Me.dtATDManila.CustomFormat = "MMM dd, yyyy"
        Me.dtATDManila.Enabled = False
        Me.dtATDManila.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATDManila.Location = New System.Drawing.Point(100, 246)
        Me.dtATDManila.Name = "dtATDManila"
        Me.dtATDManila.Size = New System.Drawing.Size(100, 20)
        Me.dtATDManila.TabIndex = 9
        Me.dtATDManila.TabStop = False
        Me.dtATDManila.Text = "Aug 25, 2020"
        Me.dtATDManila.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblATDManila
        '
        Me.lblATDManila.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATDManila.Location = New System.Drawing.Point(40, 248)
        Me.lblATDManila.Name = "lblATDManila"
        Me.lblATDManila.Size = New System.Drawing.Size(54, 18)
        Me.lblATDManila.TabIndex = 0
        Me.lblATDManila.Text = "ATD MNL"
        '
        'lblETDManila
        '
        Me.lblETDManila.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDManila.Location = New System.Drawing.Point(41, 196)
        Me.lblETDManila.Name = "lblETDManila"
        Me.lblETDManila.Size = New System.Drawing.Size(53, 18)
        Me.lblETDManila.TabIndex = 0
        Me.lblETDManila.Text = "ETD MNL"
        '
        'dtATDFEAP
        '
        Me.dtATDFEAP.CustomFormat = "MMM dd, yyyy"
        Me.dtATDFEAP.Enabled = False
        Me.dtATDFEAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATDFEAP.Location = New System.Drawing.Point(100, 220)
        Me.dtATDFEAP.Name = "dtATDFEAP"
        Me.dtATDFEAP.Size = New System.Drawing.Size(100, 20)
        Me.dtATDFEAP.TabIndex = 8
        Me.dtATDFEAP.TabStop = False
        Me.dtATDFEAP.Text = "Aug 25, 2020"
        Me.dtATDFEAP.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtETDManila
        '
        Me.dtETDManila.CustomFormat = "MMM dd, yyyy"
        Me.dtETDManila.Enabled = False
        Me.dtETDManila.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETDManila.Location = New System.Drawing.Point(100, 194)
        Me.dtETDManila.Name = "dtETDManila"
        Me.dtETDManila.Size = New System.Drawing.Size(100, 20)
        Me.dtETDManila.TabIndex = 7
        Me.dtETDManila.TabStop = False
        Me.dtETDManila.Text = "Aug 25, 2020"
        Me.dtETDManila.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtInvoiceDate
        '
        Me.dtInvoiceDate.CustomFormat = "MMM dd, yyyy"
        Me.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInvoiceDate.Location = New System.Drawing.Point(100, 142)
        Me.dtInvoiceDate.Name = "dtInvoiceDate"
        Me.dtInvoiceDate.Size = New System.Drawing.Size(120, 20)
        Me.dtInvoiceDate.TabIndex = 5
        Me.dtInvoiceDate.TabStop = False
        Me.dtInvoiceDate.Text = "Aug 25, 2020"
        Me.dtInvoiceDate.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtETDFEAP
        '
        Me.dtETDFEAP.CustomFormat = "MMM dd, yyyy"
        Me.dtETDFEAP.Enabled = False
        Me.dtETDFEAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETDFEAP.Location = New System.Drawing.Point(100, 168)
        Me.dtETDFEAP.Name = "dtETDFEAP"
        Me.dtETDFEAP.Size = New System.Drawing.Size(100, 20)
        Me.dtETDFEAP.TabIndex = 6
        Me.dtETDFEAP.TabStop = False
        Me.dtETDFEAP.Text = "Aug 25, 2020"
        Me.dtETDFEAP.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceDate.Location = New System.Drawing.Point(26, 144)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(68, 18)
        Me.lblInvoiceDate.TabIndex = 0
        Me.lblInvoiceDate.Text = "Invoice Date"
        '
        'lblATDFEAP
        '
        Me.lblATDFEAP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATDFEAP.Location = New System.Drawing.Point(39, 222)
        Me.lblATDFEAP.Name = "lblATDFEAP"
        Me.lblATDFEAP.Size = New System.Drawing.Size(55, 18)
        Me.lblATDFEAP.TabIndex = 0
        Me.lblATDFEAP.Text = "ATD FEAP"
        '
        'lblETDFEAP
        '
        Me.lblETDFEAP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDFEAP.Location = New System.Drawing.Point(40, 170)
        Me.lblETDFEAP.Name = "lblETDFEAP"
        Me.lblETDFEAP.Size = New System.Drawing.Size(54, 18)
        Me.lblETDFEAP.TabIndex = 0
        Me.lblETDFEAP.Text = "ETD FEAP"
        '
        'btnCreateInvoice
        '
        Me.btnCreateInvoice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnCreateInvoice.Image = CType(resources.GetObject("btnCreateInvoice.Image"), System.Drawing.Image)
        Me.btnCreateInvoice.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCreateInvoice.Location = New System.Drawing.Point(600, 260)
        Me.btnCreateInvoice.Name = "btnCreateInvoice"
        Me.btnCreateInvoice.Size = New System.Drawing.Size(120, 110)
        Me.btnCreateInvoice.TabIndex = 31
        Me.btnCreateInvoice.Text = "Create Invoice"
        Me.btnCreateInvoice.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreateInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCreateInvoice.ThemeName = "FluentDark"
        CType(Me.btnCreateInvoice.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.btnCreateInvoice.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.btnCreateInvoice.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btnCreateInvoice.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.TopCenter
        CType(Me.btnCreateInvoice.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Create Invoice"
        CType(Me.btnCreateInvoice.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
        CType(Me.btnCreateInvoice.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.75!)
        CType(Me.btnCreateInvoice.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmCreateInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 390)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCreateInvoice"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Invoice"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.cbATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbETDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFreightCondition.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFreightCondition.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFreightCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShippedTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShippedTo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShippedTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbBIRReference.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbBIRReference.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbBIRReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbApprovedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbApprovedBy.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbApprovedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbNotedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbNotedBy.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbNotedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCheckedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCheckedBy.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCheckedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPreparedBy.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPreparedBy.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPreparedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbSoldTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbSoldTo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbSoldTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpInvoiceUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpShipVia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numForexUSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numForex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblApprovedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblForexUSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNotedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblForex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCheckedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblShippedTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPreparedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSoldTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPCNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bllTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPONo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPCNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOfPackages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFreightTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDRNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInvoiceUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPONo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoOfPackages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFreightTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblShipVia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDRNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSailingOnOrAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSailingOnOrAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCreateInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents drpCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblCurrency As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numForex As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblForex As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblSoldTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPONo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDRNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPONo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblInvoiceNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDRNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATACustomer As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATACustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATDManila As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATDManila As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETDManila As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATDFEAP As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtETDManila As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtETDFEAP As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATDFEAP As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETDFEAP As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCreateInvoice As Telerik.WinControls.UI.RadButton
    Friend WithEvents numInvoiceNo As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblActivity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtInvoiceDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblInvoiceDate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpActivity As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents mcbCustomer As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbSoldTo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtPCNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPCNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbShippedTo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblShippedTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTerms As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents bllTerms As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbFreightCondition As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents drpInvoiceUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblRemarks As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtNoOfPackages As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtFreightTerms As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblInvoiceUOM As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblNoOfPackages As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblFreightTerms As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblShipVia As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtSailingOnOrAbout As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblSailingOnOrAbout As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbBIRReference As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbApprovedBy As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbNotedBy As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbCheckedBy As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbPreparedBy As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblApprovedBy As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblNotedBy As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCheckedBy As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblPreparedBy As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbATACustomer As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbATDManila As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbATDFEAP As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbETDManila As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbETDFEAP As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents txtDescription As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblDescription As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpShipVia As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents numForexUSD As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblForexUSD As Telerik.WinControls.UI.RadLabel
End Class

