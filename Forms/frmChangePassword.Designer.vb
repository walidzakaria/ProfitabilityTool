<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePassword))
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNewPassword = New DevExpress.XtraEditors.TextEdit()
        Me.TxtOldPassword = New DevExpress.XtraEditors.TextEdit()
        Me.TxtRetype = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TxtNewPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOldPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRetype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Appearance.ForeColor = System.Drawing.Color.Red
        Me.BtnCancel.Appearance.Options.UseFont = True
        Me.BtnCancel.Appearance.Options.UseForeColor = True
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(411, 173)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(106, 32)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Appearance.ForeColor = System.Drawing.Color.Green
        Me.BtnOK.Appearance.Options.UseFont = True
        Me.BtnOK.Appearance.Options.UseForeColor = True
        Me.BtnOK.Location = New System.Drawing.Point(299, 173)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(106, 32)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "OK"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(37, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(109, 19)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "New Password:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(37, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "Old Password:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(37, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl3.TabIndex = 18
        Me.LabelControl3.Text = "Retype:"
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.EnterMoveNextControl = True
        Me.TxtNewPassword.Location = New System.Drawing.Point(169, 76)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtNewPassword.Properties.Appearance.Options.UseFont = True
        Me.TxtNewPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtNewPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewPassword.Size = New System.Drawing.Size(323, 24)
        Me.TxtNewPassword.TabIndex = 20
        '
        'TxtOldPassword
        '
        Me.TxtOldPassword.EnterMoveNextControl = True
        Me.TxtOldPassword.Location = New System.Drawing.Point(169, 36)
        Me.TxtOldPassword.Name = "TxtOldPassword"
        Me.TxtOldPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtOldPassword.Properties.Appearance.Options.UseFont = True
        Me.TxtOldPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtOldPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOldPassword.Size = New System.Drawing.Size(323, 24)
        Me.TxtOldPassword.TabIndex = 19
        '
        'TxtRetype
        '
        Me.TxtRetype.EnterMoveNextControl = True
        Me.TxtRetype.Location = New System.Drawing.Point(169, 118)
        Me.TxtRetype.Name = "TxtRetype"
        Me.TxtRetype.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtRetype.Properties.Appearance.Options.UseFont = True
        Me.TxtRetype.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtRetype.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtRetype.Size = New System.Drawing.Size(323, 24)
        Me.TxtRetype.TabIndex = 21
        '
        'FrmChangePassword
        '
        Me.AllowControlsInImageMode = True
        Me.AutoFitImage = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(536, 217)
        Me.Controls.Add(Me.TxtRetype)
        Me.Controls.Add(Me.TxtNewPassword)
        Me.Controls.Add(Me.TxtOldPassword)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmChangePassword"
        Me.ShowMode = DevExpress.XtraSplashScreen.ShowMode.Image
        Me.SplashImageOptions.Image = Global.ProfitabilityTool.My.Resources.Resources.Sign_up
        Me.Text = "Login"
        CType(Me.TxtNewPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOldPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRetype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNewPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtOldPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtRetype As DevExpress.XtraEditors.TextEdit
End Class
