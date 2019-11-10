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
        Me.btnRun = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.meQuery = New DevExpress.XtraEditors.MemoEdit()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutControl1.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meQuery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'layoutControl1
        '
        Me.layoutControl1.Controls.Add(Me.btnRun)
        Me.layoutControl1.Controls.Add(Me.btnClear)
        Me.layoutControl1.Controls.Add(Me.gridControl1)
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
        'gridControl1
        '
        Me.gridControl1.Location = New System.Drawing.Point(12, 12)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Size = New System.Drawing.Size(836, 247)
        Me.gridControl1.TabIndex = 4
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'gridView1
        '
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"
        '
        'meQuery
        '
        Me.meQuery.Location = New System.Drawing.Point(74, 263)
        Me.meQuery.Name = "meQuery"
        Me.meQuery.Size = New System.Drawing.Size(774, 141)
        Me.meQuery.StyleController = Me.layoutControl1
        Me.meQuery.TabIndex = 7
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.LayoutControlItem4})
        Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(860, 442)
        Me.layoutControlGroup1.TextVisible = False
        '
        'layoutControlItem1
        '
        Me.layoutControlItem1.Control = Me.gridControl1
        Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlItem1.Name = "layoutControlItem1"
        Me.layoutControlItem1.Size = New System.Drawing.Size(840, 251)
        Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutControlItem1.TextVisible = False
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
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.meQuery
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 251)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(840, 145)
        Me.LayoutControlItem4.Text = "Query Text:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(59, 13)
        '
        'frmSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 442)
        Me.Controls.Add(Me.layoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSQL"
        Me.Text = "SQL"
        CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutControl1.ResumeLayout(False)
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meQuery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents layoutControl1 As DevExpress.XtraLayout.LayoutControl
    Private WithEvents btnRun As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents meQuery As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
