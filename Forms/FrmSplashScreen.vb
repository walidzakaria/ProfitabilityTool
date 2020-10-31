Public Class FrmSplashScreen
    Sub New
        InitializeComponent()
        Me.LabelCopyright.Text = "Copyright RedSea24© 2020-" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

End Class
