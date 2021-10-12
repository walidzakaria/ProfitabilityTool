<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUpdateRates
    Inherits DevExpress.XtraSplashScreen.SplashScreen

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
        Me.labelStatus = New DevExpress.XtraEditors.LabelControl()
        Me.labelSuccess = New DevExpress.XtraEditors.LabelControl()
        Me.labelFailure = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelStatus
        '
        Me.labelStatus.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.labelStatus.Appearance.Options.UseFont = True
        Me.labelStatus.Location = New System.Drawing.Point(24, 13)
        Me.labelStatus.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(49, 13)
        Me.labelStatus.TabIndex = 12
        Me.labelStatus.Text = "Starting..."
        '
        'labelSuccess
        '
        Me.labelSuccess.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.labelSuccess.Appearance.Options.UseFont = True
        Me.labelSuccess.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelSuccess.Location = New System.Drawing.Point(24, 57)
        Me.labelSuccess.Name = "labelSuccess"
        Me.labelSuccess.Size = New System.Drawing.Size(62, 13)
        Me.labelSuccess.TabIndex = 11
        Me.labelSuccess.Text = "Total Sucess"
        '
        'labelFailure
        '
        Me.labelFailure.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.labelFailure.Appearance.Options.UseFont = True
        Me.labelFailure.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelFailure.Location = New System.Drawing.Point(24, 76)
        Me.labelFailure.Name = "labelFailure"
        Me.labelFailure.Size = New System.Drawing.Size(60, 13)
        Me.labelFailure.TabIndex = 15
        Me.labelFailure.Text = "Total Failed"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Appearance.Options.UseForeColor = True
        Me.btnCancel.Location = New System.Drawing.Point(351, 89)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(24, 33)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(402, 18)
        Me.ProgressBarControl1.TabIndex = 17
        '
        'FrmProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 133)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.labelFailure)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.labelSuccess)
        Me.Name = "FrmProgress"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "FrmProgress"
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents labelStatus As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelSuccess As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelFailure As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
End Class
