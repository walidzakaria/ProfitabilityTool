<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmManageSection
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
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManageSection))
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions4 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions5 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions6 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.itemLabel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.itemGrid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.WindowsUIButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutControl.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'layoutControl
        '
        Me.layoutControl.AllowCustomization = False
        Me.layoutControl.Controls.Add(Me.LabelControl)
        Me.layoutControl.Controls.Add(Me.GridControl)
        Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutControl.Location = New System.Drawing.Point(0, 0)
        Me.layoutControl.Name = "layoutControl"
        Me.layoutControl.Root = Me.layoutControlGroup
        Me.layoutControl.Size = New System.Drawing.Size(584, 501)
        Me.layoutControl.TabIndex = 1
        '
        'LabelControl
        '
        Me.LabelControl.AllowHtmlString = True
        Me.LabelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.LabelControl.Appearance.Options.UseFont = True
        Me.LabelControl.Appearance.Options.UseForeColor = True
        Me.LabelControl.Appearance.Options.UseTextOptions = True
        Me.LabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl.Location = New System.Drawing.Point(40, 0)
        Me.LabelControl.Name = "LabelControl"
        Me.LabelControl.Padding = New System.Windows.Forms.Padding(0, 3, 13, 6)
        Me.LabelControl.Size = New System.Drawing.Size(504, 34)
        Me.LabelControl.StyleController = Me.layoutControl
        Me.LabelControl.TabIndex = 4
        Me.LabelControl.Text = "Manage Section"
        '
        'GridControl
        '
        Me.GridControl.Location = New System.Drawing.Point(40, 34)
        Me.GridControl.MainView = Me.gridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(504, 467)
        Me.GridControl.TabIndex = 2
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn8})
        Me.gridView.GridControl = Me.GridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsCustomization.AllowColumnMoving = False
        Me.gridView.OptionsCustomization.AllowGroup = False
        Me.gridView.OptionsCustomization.AllowQuickHideColumns = False
        Me.gridView.OptionsMenu.EnableColumnMenu = False
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "SectionID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowShowHide = False
        Me.GridColumn1.Width = 20
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Status"
        Me.GridColumn2.FieldName = "Status"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 150
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Section"
        Me.GridColumn8.FieldName = "Section"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 352
        '
        'layoutControlGroup
        '
        Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup.GroupBordersVisible = False
        Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemLabel, Me.itemGrid})
        Me.layoutControlGroup.Name = "layoutControlGroup"
        Me.layoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0)
        Me.layoutControlGroup.Size = New System.Drawing.Size(584, 501)
        Me.layoutControlGroup.TextVisible = False
        '
        'itemLabel
        '
        Me.itemLabel.Control = Me.LabelControl
        Me.itemLabel.Location = New System.Drawing.Point(0, 0)
        Me.itemLabel.Name = "itemLabel"
        Me.itemLabel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemLabel.Size = New System.Drawing.Size(504, 34)
        Me.itemLabel.TextSize = New System.Drawing.Size(0, 0)
        Me.itemLabel.TextVisible = False
        '
        'itemGrid
        '
        Me.itemGrid.Control = Me.GridControl
        Me.itemGrid.Location = New System.Drawing.Point(0, 34)
        Me.itemGrid.Name = "itemGrid"
        Me.itemGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemGrid.Size = New System.Drawing.Size(504, 467)
        Me.itemGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.itemGrid.TextVisible = False
        '
        'WindowsUIButtonPanel
        '
        Me.WindowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.WindowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1
        Me.WindowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.WindowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = True
        Me.WindowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = True
        Me.WindowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = True
        Me.WindowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1
        Me.WindowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = True
        Me.WindowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.WindowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1
        Me.WindowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.WindowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = True
        Me.WindowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = True
        Me.WindowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.WindowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        WindowsUIButtonImageOptions1.ImageUri.Uri = "Delete;GrayScaled"
        WindowsUIButtonImageOptions2.Image = CType(resources.GetObject("WindowsUIButtonImageOptions2.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions3.ImageUri.Uri = "New;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions4.ImageUri.Uri = "Preview;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions5.ImageUri.Uri = "Refresh;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions6.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled"
        Me.WindowsUIButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("New", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", True, WindowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Close", True, WindowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WindowsUIButtonPanel.EnableImageTransparency = True
        Me.WindowsUIButtonPanel.ForeColor = System.Drawing.Color.White
        Me.WindowsUIButtonPanel.Location = New System.Drawing.Point(0, 501)
        Me.WindowsUIButtonPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WindowsUIButtonPanel.MaximumSize = New System.Drawing.Size(0, 60)
        Me.WindowsUIButtonPanel.MinimumSize = New System.Drawing.Size(60, 60)
        Me.WindowsUIButtonPanel.Name = "WindowsUIButtonPanel"
        Me.WindowsUIButtonPanel.Size = New System.Drawing.Size(584, 60)
        Me.WindowsUIButtonPanel.TabIndex = 7
        Me.WindowsUIButtonPanel.Text = "windowsUIButtonPanel"
        Me.WindowsUIButtonPanel.UseButtonBackgroundImages = False
        '
        'FrmManageSection
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.layoutControl)
        Me.Controls.Add(Me.WindowsUIButtonPanel)
        Me.IconOptions.Image = Global.ProfitabilityTool.My.Resources.Resources.profitability_logo
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.Name = "FrmManageSection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutControl.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Private WithEvents LabelControl As DevExpress.XtraEditors.LabelControl
    Private WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents itemLabel As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents itemGrid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents WindowsUIButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
End Class
