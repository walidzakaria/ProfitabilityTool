<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSQL))
        Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnRun = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.meQuery = New DevExpress.XtraEditors.MemoEdit()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meQuery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'layoutControl1
        '
        Me.layoutControl1.Controls.Add(Me.GridControl1)
        Me.layoutControl1.Controls.Add(Me.btnRun)
        Me.layoutControl1.Controls.Add(Me.btnClear)
        Me.layoutControl1.Controls.Add(Me.meQuery)
        Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.layoutControl1.Name = "layoutControl1"
        Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(626, 205, 727, 596)
        Me.layoutControl1.Root = Me.layoutControlGroup1
        Me.layoutControl1.Size = New System.Drawing.Size(860, 442)
        Me.layoutControl1.TabIndex = 1
        Me.layoutControl1.Text = "layoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(836, 310)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(422, 408)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(426, 22)
        Me.btnRun.StyleController = Me.layoutControl1
        Me.btnRun.TabIndex = 6
        Me.btnRun.Text = "Run"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 408)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(406, 22)
        Me.btnClear.StyleController = Me.layoutControl1
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        '
        'meQuery
        '
        Me.meQuery.Location = New System.Drawing.Point(74, 326)
        Me.meQuery.Name = "meQuery"
        Me.meQuery.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meQuery.Properties.Appearance.Options.UseFont = True
        Me.meQuery.Size = New System.Drawing.Size(774, 78)
        Me.meQuery.StyleController = Me.layoutControl1
        Me.meQuery.TabIndex = 7
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem4})
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(860, 442)
        Me.layoutControlGroup1.TextVisible = False
        '
        'layoutControlItem2
        '
        Me.layoutControlItem2.Control = Me.btnClear
        Me.layoutControlItem2.Location = New System.Drawing.Point(0, 396)
        Me.layoutControlItem2.Name = "layoutControlItem2"
        Me.layoutControlItem2.Size = New System.Drawing.Size(410, 26)
        Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutControlItem2.TextVisible = False
        '
        'layoutControlItem3
        '
        Me.layoutControlItem3.Control = Me.btnRun
        Me.layoutControlItem3.Location = New System.Drawing.Point(410, 396)
        Me.layoutControlItem3.Name = "layoutControlItem3"
        Me.layoutControlItem3.Size = New System.Drawing.Size(430, 26)
        Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(840, 314)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.meQuery
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 314)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(840, 82)
        Me.LayoutControlItem4.Text = "Query Text:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(59, 13)
        '
        'frmSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 442)
        Me.Controls.Add(Me.layoutControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("frmSQL.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.ProfitabilityTool.My.Resources.Resources.profitability_logo
        Me.KeyPreview = True
        Me.Name = "frmSQL"
        Me.Text = "SQL"
        CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meQuery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents layoutControl1 As DevExpress.XtraLayout.LayoutControl
    Private WithEvents btnRun As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Private WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents meQuery As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
