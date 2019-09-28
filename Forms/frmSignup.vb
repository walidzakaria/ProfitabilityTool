Public Class frmSignup
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub frmSignup_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 100%
    End Sub

    Private Sub frmSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 100%
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtRetype.Text = ""
        rgAuthority.SelectedIndex = 0
        txtUserName.Focus()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSignup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtUserName.Focus()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtUserName.Text = "" Then
            txtUserName.Focus()
        ElseIf txtPassword.Text = "" Then
            txtPassword.Focus()
        ElseIf Not txtPassword.Text = txtRetype.Text Then
            MessageBox.Show("You have retyped the password incorrectly. You must type the same password twice!      ", "Password Not Matching", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            txtRetype.Text = ""
            txtPassword.Focus()
        Else
            Dim user As New Login()
            user.Username = txtUserName.Text
            user.Password = txtPassword.Text
            user.Authority = rgAuthority.EditValue
            
            user.Active = True
            If Not user.UniqueUsername Then
                MsgBox("The entered username already exists, please select a unique username!")
            Else
                If user.Signup() Then
                    MsgBox(String.Format("User '{0}' has been signed up successfully!", user.Username))
                    Me.Close()
                Else
                    MsgBox("Failed to sign up!")
                End If
            End If
        End If
    End Sub
End Class
