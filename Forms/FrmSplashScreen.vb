Public Class FrmSplashScreen
    Sub New
        InitializeComponent()
        Me.LabelCopyright.Text = "Copyright RedSea24© 2020-" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not UpToDate() Then
            RunUpdater()
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.Hide()
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Function UpToDate() As Boolean
        Dim result As Boolean
        Dim dt As DataTable = ExClass.QueryGet("SELECT * FROM VersionNumber;")
        result = dt.Rows(0)(0).ToString.Equals(Application.ProductVersion)
        Return result
    End Function

    Private Sub RunUpdater()
        Shell("PR_Updater.exe")
        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Profitability_Tool")
        For Each p As Process In pProcess
            p.Kill()
        Next
        Application.Exit()
    End Sub
End Class
