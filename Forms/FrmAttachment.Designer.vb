<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttachment
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAttachment))
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions4 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions5 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.windowsUIButtonPanelMain = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(494, 238)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "AttachmentID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Time"
        Me.GridColumn2.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Time"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 139
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "File Name"
        Me.GridColumn3.FieldName = "AttachmentName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 139
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Username"
        Me.GridColumn4.FieldName = "Username"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 60
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
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions2.SvgImage = CType(resources.GetObject("WindowsUIButtonImageOptions2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        WindowsUIButtonImageOptions3.ImageUri.Uri = "Save;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions3.SvgImage = CType(resources.GetObject("WindowsUIButtonImageOptions3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        WindowsUIButtonImageOptions4.ImageUri.Uri = "Reset;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions4.SvgImage = CType(resources.GetObject("WindowsUIButtonImageOptions4.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        WindowsUIButtonImageOptions5.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled"
        Me.windowsUIButtonPanelMain.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("View", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Browse", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Paste", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Close", True, WindowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.windowsUIButtonPanelMain.EnableImageTransparency = True
        Me.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White
        Me.windowsUIButtonPanelMain.Location = New System.Drawing.Point(0, 238)
        Me.windowsUIButtonPanelMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.windowsUIButtonPanelMain.MaximumSize = New System.Drawing.Size(0, 60)
        Me.windowsUIButtonPanelMain.MinimumSize = New System.Drawing.Size(60, 60)
        Me.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain"
        Me.windowsUIButtonPanelMain.Size = New System.Drawing.Size(494, 60)
        Me.windowsUIButtonPanelMain.TabIndex = 2
        Me.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain"
        Me.windowsUIButtonPanelMain.UseButtonBackgroundImages = False
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.FileName = "XtraOpenFileDialog1"
        Me.XtraOpenFileDialog1.Multiselect = True
        '
        'FrmAttachment
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 298)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.windowsUIButtonPanelMain)
        Me.IconOptions.Image = CType(resources.GetObject("FrmAttachment.IconOptions.Image"), System.Drawing.Image)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmAttachment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attachments"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents windowsUIButtonPanelMain As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
End Class
