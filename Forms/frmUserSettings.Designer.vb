<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmUserSettings
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
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.ClbOperator = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ClbDestination = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.WindowsUIButtonPanelMain = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.lblUsername = New DevExpress.XtraEditors.LabelControl()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayoutControl1.SuspendLayout()
        CType(Me.ClbOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClbDestination, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataLayoutControl1
        '
        Me.dataLayoutControl1.AllowCustomization = False
        Me.dataLayoutControl1.Controls.Add(Me.ClbOperator)
        Me.dataLayoutControl1.Controls.Add(Me.ClbDestination)
        Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 30)
        Me.dataLayoutControl1.Name = "dataLayoutControl1"
        Me.dataLayoutControl1.Root = Me.layoutControlGroup1
        Me.dataLayoutControl1.Size = New System.Drawing.Size(411, 219)
        Me.dataLayoutControl1.TabIndex = 0
        '
        'ClbOperator
        '
        Me.ClbOperator.CheckOnClick = True
        Me.ClbOperator.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClbOperator.Location = New System.Drawing.Point(212, 12)
        Me.ClbOperator.Name = "ClbOperator"
        Me.ClbOperator.Size = New System.Drawing.Size(187, 195)
        Me.ClbOperator.StyleController = Me.dataLayoutControl1
        Me.ClbOperator.TabIndex = 7
        '
        'ClbDestination
        '
        Me.ClbDestination.CheckOnClick = True
        Me.ClbDestination.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClbDestination.Location = New System.Drawing.Point(12, 12)
        Me.ClbDestination.Name = "ClbDestination"
        Me.ClbDestination.Size = New System.Drawing.Size(196, 195)
        Me.ClbDestination.StyleController = Me.dataLayoutControl1
        Me.ClbDestination.TabIndex = 6
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(411, 219)
        Me.layoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ClbDestination
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(200, 199)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ClbOperator
        Me.LayoutControlItem2.Location = New System.Drawing.Point(200, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(191, 199)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
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
        Me.WindowsUIButtonPanelMain.Location = New System.Drawing.Point(0, 249)
        Me.WindowsUIButtonPanelMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WindowsUIButtonPanelMain.MaximumSize = New System.Drawing.Size(0, 60)
        Me.WindowsUIButtonPanelMain.MinimumSize = New System.Drawing.Size(60, 60)
        Me.WindowsUIButtonPanelMain.Name = "WindowsUIButtonPanelMain"
        Me.WindowsUIButtonPanelMain.Size = New System.Drawing.Size(411, 60)
        Me.WindowsUIButtonPanelMain.TabIndex = 3
        Me.WindowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain"
        Me.WindowsUIButtonPanelMain.UseButtonBackgroundImages = False
        '
        'lblUsername
        '
        Me.lblUsername.AllowHtmlString = True
        Me.lblUsername.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblUsername.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblUsername.Appearance.Options.UseFont = True
        Me.lblUsername.Appearance.Options.UseForeColor = True
        Me.lblUsername.Appearance.Options.UseTextOptions = True
        Me.lblUsername.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblUsername.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblUsername.Location = New System.Drawing.Point(0, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.lblUsername.Size = New System.Drawing.Size(411, 30)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "User Options"
        '
        'FrmUserSettings
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(411, 309)
        Me.Controls.Add(Me.dataLayoutControl1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.WindowsUIButtonPanelMain)
        Me.IconOptions.Image = Global.ProfitabilityTool.My.Resources.Resources.profitability_logo
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmUserSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayoutControl1.ResumeLayout(False)
        CType(Me.ClbOperator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClbDestination, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Private WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents WindowsUIButtonPanelMain As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Private WithEvents lblUsername As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents ClbOperator As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ClbDestination As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
