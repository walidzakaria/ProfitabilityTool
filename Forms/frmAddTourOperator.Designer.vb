﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmAddTourOperator
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
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TxtTourOperator = New DevExpress.XtraEditors.TextEdit()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.WindowsUIButtonPanelMain = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.labelControl = New DevExpress.XtraEditors.LabelControl()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayoutControl1.SuspendLayout()
        CType(Me.TxtTourOperator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataLayoutControl1
        '
        Me.dataLayoutControl1.AllowCustomization = False
        Me.dataLayoutControl1.Controls.Add(Me.TxtTourOperator)
        Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 30)
        Me.dataLayoutControl1.Name = "dataLayoutControl1"
        Me.dataLayoutControl1.Root = Me.layoutControlGroup1
        Me.dataLayoutControl1.Size = New System.Drawing.Size(313, 99)
        Me.dataLayoutControl1.TabIndex = 0
        '
        'TxtTourOperator
        '
        Me.TxtTourOperator.Location = New System.Drawing.Point(84, 12)
        Me.TxtTourOperator.Name = "TxtTourOperator"
        Me.TxtTourOperator.Size = New System.Drawing.Size(217, 20)
        Me.TxtTourOperator.StyleController = Me.dataLayoutControl1
        Me.TxtTourOperator.TabIndex = 5
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.TxtTourOperator, ConditionValidationRule1)
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(313, 99)
        Me.layoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtTourOperator
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(293, 79)
        Me.LayoutControlItem2.Text = "Tour Operator"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
        '
        'WindowsUIButtonPanelMain
        '
        Me.WindowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.WindowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1
        Me.WindowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.WindowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = True
        Me.WindowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = True
        Me.WindowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = True
        Me.WindowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1
        Me.WindowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = True
        Me.WindowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.WindowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1
        Me.WindowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.WindowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = True
        Me.WindowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = True
        Me.WindowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.WindowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        WindowsUIButtonImageOptions1.ImageUri.Uri = "Save;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions2.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled"
        Me.WindowsUIButtonPanelMain.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Cancel", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WindowsUIButtonPanelMain.EnableImageTransparency = True
        Me.WindowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White
        Me.WindowsUIButtonPanelMain.Location = New System.Drawing.Point(0, 129)
        Me.WindowsUIButtonPanelMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WindowsUIButtonPanelMain.MaximumSize = New System.Drawing.Size(0, 60)
        Me.WindowsUIButtonPanelMain.MinimumSize = New System.Drawing.Size(60, 60)
        Me.WindowsUIButtonPanelMain.Name = "WindowsUIButtonPanelMain"
        Me.WindowsUIButtonPanelMain.Size = New System.Drawing.Size(313, 60)
        Me.WindowsUIButtonPanelMain.TabIndex = 3
        Me.WindowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain"
        Me.WindowsUIButtonPanelMain.UseButtonBackgroundImages = False
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
        Me.labelControl.Size = New System.Drawing.Size(313, 30)
        Me.labelControl.TabIndex = 1
        Me.labelControl.Text = "New Tour Operator"
        '
        'FrmAddTourOperator
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(313, 189)
        Me.Controls.Add(Me.dataLayoutControl1)
        Me.Controls.Add(Me.labelControl)
        Me.Controls.Add(Me.WindowsUIButtonPanelMain)
        Me.IconOptions.Image = Global.ProfitabilityTool.My.Resources.Resources.profitability_logo
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmAddTourOperator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayoutControl1.ResumeLayout(False)
        CType(Me.TxtTourOperator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Private WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents WindowsUIButtonPanelMain As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Private WithEvents labelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTourOperator As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
