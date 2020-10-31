<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmAddMargin
    Inherits DevExpress.XtraEditors.XtraForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    '''
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.txtMarginFrom = New DevExpress.XtraEditors.TextEdit()
        Me.txtMarginTo = New DevExpress.XtraEditors.TextEdit()
        Me.deEffectiveDate = New DevExpress.XtraEditors.DateEdit()
        Me.luDestination = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDifferenceFrom = New DevExpress.XtraEditors.TextEdit()
        Me.txtDifferenceTo = New DevExpress.XtraEditors.TextEdit()
        Me.luTourOperator = New DevExpress.XtraEditors.LookUpEdit()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.windowsUIButtonPanelMain = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.labelControl = New DevExpress.XtraEditors.LabelControl()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.DxValidationProvider2 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayoutControl1.SuspendLayout()
        CType(Me.txtMarginFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarginTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEffectiveDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEffectiveDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luDestination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDifferenceFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDifferenceTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luTourOperator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataLayoutControl1
        '
        Me.dataLayoutControl1.AllowCustomization = False
        Me.dataLayoutControl1.Controls.Add(Me.txtMarginFrom)
        Me.dataLayoutControl1.Controls.Add(Me.txtMarginTo)
        Me.dataLayoutControl1.Controls.Add(Me.deEffectiveDate)
        Me.dataLayoutControl1.Controls.Add(Me.luDestination)
        Me.dataLayoutControl1.Controls.Add(Me.txtDifferenceFrom)
        Me.dataLayoutControl1.Controls.Add(Me.txtDifferenceTo)
        Me.dataLayoutControl1.Controls.Add(Me.luTourOperator)
        Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 30)
        Me.dataLayoutControl1.Name = "dataLayoutControl1"
        Me.dataLayoutControl1.Root = Me.layoutControlGroup1
        Me.dataLayoutControl1.Size = New System.Drawing.Size(314, 189)
        Me.dataLayoutControl1.TabIndex = 0
        '
        'txtMarginFrom
        '
        Me.txtMarginFrom.Location = New System.Drawing.Point(96, 60)
        Me.txtMarginFrom.Name = "txtMarginFrom"
        Me.txtMarginFrom.Properties.Mask.EditMask = "-?\d+(\R.\d{0,2})?"
        Me.txtMarginFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtMarginFrom.Size = New System.Drawing.Size(206, 20)
        Me.txtMarginFrom.StyleController = Me.dataLayoutControl1
        Me.txtMarginFrom.TabIndex = 5
        '
        'txtMarginTo
        '
        Me.txtMarginTo.Location = New System.Drawing.Point(96, 84)
        Me.txtMarginTo.Name = "txtMarginTo"
        Me.txtMarginTo.Properties.Mask.EditMask = "-?\d+(\R.\d{0,2})?"
        Me.txtMarginTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtMarginTo.Size = New System.Drawing.Size(206, 20)
        Me.txtMarginTo.StyleController = Me.dataLayoutControl1
        Me.txtMarginTo.TabIndex = 6
        '
        'deEffectiveDate
        '
        Me.deEffectiveDate.EditValue = Nothing
        Me.deEffectiveDate.Location = New System.Drawing.Point(96, 156)
        Me.deEffectiveDate.Name = "deEffectiveDate"
        Me.deEffectiveDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEffectiveDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEffectiveDate.Size = New System.Drawing.Size(206, 20)
        Me.deEffectiveDate.StyleController = Me.dataLayoutControl1
        Me.deEffectiveDate.TabIndex = 7
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.deEffectiveDate, ConditionValidationRule1)
        '
        'luDestination
        '
        Me.luDestination.Location = New System.Drawing.Point(96, 12)
        Me.luDestination.Name = "luDestination"
        Me.luDestination.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luDestination.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DestinationID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DestinationCode", "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Destination", "Destination")})
        Me.luDestination.Properties.NullText = ""
        Me.luDestination.Size = New System.Drawing.Size(206, 20)
        Me.luDestination.StyleController = Me.dataLayoutControl1
        Me.luDestination.TabIndex = 4
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.luDestination, ConditionValidationRule2)
        '
        'txtDifferenceFrom
        '
        Me.txtDifferenceFrom.Location = New System.Drawing.Point(96, 108)
        Me.txtDifferenceFrom.Name = "txtDifferenceFrom"
        Me.txtDifferenceFrom.Properties.Mask.EditMask = "-?\d+(\R.\d{0,2})?"
        Me.txtDifferenceFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtDifferenceFrom.Size = New System.Drawing.Size(206, 20)
        Me.txtDifferenceFrom.StyleController = Me.dataLayoutControl1
        Me.txtDifferenceFrom.TabIndex = 5
        '
        'txtDifferenceTo
        '
        Me.txtDifferenceTo.Location = New System.Drawing.Point(96, 132)
        Me.txtDifferenceTo.Name = "txtDifferenceTo"
        Me.txtDifferenceTo.Properties.Mask.EditMask = "-?\d+(\R.\d{0,2})?"
        Me.txtDifferenceTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtDifferenceTo.Size = New System.Drawing.Size(206, 20)
        Me.txtDifferenceTo.StyleController = Me.dataLayoutControl1
        Me.txtDifferenceTo.TabIndex = 5
        '
        'luTourOperator
        '
        Me.luTourOperator.Location = New System.Drawing.Point(96, 36)
        Me.luTourOperator.Name = "luTourOperator"
        Me.luTourOperator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luTourOperator.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TourOperatorID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TourOperator", "TourOperator")})
        Me.luTourOperator.Properties.NullText = ""
        Me.luTourOperator.Size = New System.Drawing.Size(206, 20)
        Me.luTourOperator.StyleController = Me.dataLayoutControl1
        Me.luTourOperator.TabIndex = 4
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "This value is not valid"
        Me.DxValidationProvider2.SetValidationRule(Me.luTourOperator, ConditionValidationRule3)
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem4, Me.LayoutControlItem7})
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(314, 189)
        Me.layoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.luDestination
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem1.Text = "Destination:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtMarginFrom
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem2.Text = "Margin From:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtMarginTo
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem3.Text = "Margin To:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtDifferenceFrom
        Me.LayoutControlItem5.CustomizationFormText = "Margin From:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem5.Text = "Difference From:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtDifferenceTo
        Me.LayoutControlItem6.CustomizationFormText = "Margin From:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem6.Text = "Difference To:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.deEffectiveDate
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(294, 25)
        Me.LayoutControlItem4.Text = "Effective Date:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.luTourOperator
        Me.LayoutControlItem7.CustomizationFormText = "Destination:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem7.Text = "Tour Operator:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(81, 13)
        '
        'windowsUIButtonPanelMain
        '
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1
        Me.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = True
        Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        WindowsUIButtonImageOptions1.ImageUri.Uri = "Save;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions2.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled"
        Me.windowsUIButtonPanelMain.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Cancel", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.windowsUIButtonPanelMain.EnableImageTransparency = True
        Me.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White
        Me.windowsUIButtonPanelMain.Location = New System.Drawing.Point(0, 219)
        Me.windowsUIButtonPanelMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.windowsUIButtonPanelMain.MaximumSize = New System.Drawing.Size(0, 60)
        Me.windowsUIButtonPanelMain.MinimumSize = New System.Drawing.Size(60, 60)
        Me.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain"
        Me.windowsUIButtonPanelMain.Size = New System.Drawing.Size(314, 60)
        Me.windowsUIButtonPanelMain.TabIndex = 3
        Me.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain"
        Me.windowsUIButtonPanelMain.UseButtonBackgroundImages = False
        '
        'labelControl
        '
        Me.labelControl.AllowHtmlString = True
        Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labelControl.Appearance.Options.UseFont = True
        Me.labelControl.Appearance.Options.UseForeColor = True
        Me.labelControl.Appearance.Options.UseTextOptions = True
        Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelControl.Location = New System.Drawing.Point(0, 0)
        Me.labelControl.Name = "labelControl"
        Me.labelControl.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.labelControl.Size = New System.Drawing.Size(314, 30)
        Me.labelControl.TabIndex = 1
        Me.labelControl.Text = "New Margin"
        '
        'FrmAddMargin
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(314, 279)
        Me.Controls.Add(Me.dataLayoutControl1)
        Me.Controls.Add(Me.labelControl)
        Me.Controls.Add(Me.windowsUIButtonPanelMain)
        Me.IconOptions.Image = Global.ProfitabilityTool.My.Resources.Resources.profitability_logo
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmAddMargin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayoutControl1.ResumeLayout(False)
        CType(Me.txtMarginFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarginTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEffectiveDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEffectiveDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luDestination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDifferenceFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDifferenceTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luTourOperator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Private WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents windowsUIButtonPanelMain As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Private WithEvents labelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMarginFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtMarginTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents deEffectiveDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents luDestination As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDifferenceFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDifferenceTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents luTourOperator As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DxValidationProvider2 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
End Class
