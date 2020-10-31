Public Class FrmAbout
    Sub New
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub FrmAbout_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 100%
        txtVersion.EditValue = String.Format("Version No. {0}", Application.ProductVersion)
    End Sub

    Private Sub FrmAbout_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Opacity = 100%
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub
End Class
