Public Class frmAbout
    Sub New
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 100%
        txtVersion.EditValue = String.Format("Version No. {0}", Application.ProductVersion)
    End Sub

    Private Sub frmAbout_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Opacity = 100%
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class
