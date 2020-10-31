<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplashScreen
    Inherits DevExpress.XtraSplashScreen.SplashScreen

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
        Me.LabelStatus = New DevExpress.XtraEditors.LabelControl()
        Me.LabelCopyright = New DevExpress.XtraEditors.LabelControl()
        Me.ProgressBarControl = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.PeImage = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.ProgressBarControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelStatus
        '
        Me.LabelStatus.Location = New System.Drawing.Point(355, 194)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(50, 13)
        Me.LabelStatus.TabIndex = 12
        Me.LabelStatus.Text = "Starting..."
        '
        'LabelCopyright
        '
        Me.LabelCopyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelCopyright.Location = New System.Drawing.Point(23, 194)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(47, 13)
        Me.LabelCopyright.TabIndex = 11
        Me.LabelCopyright.Text = "Copyright"
        '
        'ProgressBarControl
        '
        Me.ProgressBarControl.EditValue = 0
        Me.ProgressBarControl.Location = New System.Drawing.Point(23, 213)
        Me.ProgressBarControl.Name = "ProgressBarControl"
        Me.ProgressBarControl.Size = New System.Drawing.Size(382, 15)
        Me.ProgressBarControl.TabIndex = 10
        '
        'PeImage
        '
        Me.PeImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.PeImage.EditValue = Global.ProfitabilityTool.My.Resources.Resources.profitability_splash
        Me.PeImage.Location = New System.Drawing.Point(3, 8)
        Me.PeImage.Name = "PeImage"
        Me.PeImage.Properties.AllowFocused = False
        Me.PeImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PeImage.Properties.Appearance.Options.UseBackColor = True
        Me.PeImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PeImage.Properties.ShowMenu = False
        Me.PeImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PeImage.Size = New System.Drawing.Size(426, 180)
        Me.PeImage.TabIndex = 14
        '
        'FrmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 238)
        Me.Controls.Add(Me.PeImage)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.ProgressBarControl)
        Me.Name = "FrmSplashScreen"
        Me.Text = "Form1"
        CType(Me.ProgressBarControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents PeImage As DevExpress.XtraEditors.PictureEdit
    Private WithEvents LabelStatus As DevExpress.XtraEditors.LabelControl
    Private WithEvents LabelCopyright As DevExpress.XtraEditors.LabelControl
    Private WithEvents ProgressBarControl As DevExpress.XtraEditors.MarqueeProgressBarControl
End Class
