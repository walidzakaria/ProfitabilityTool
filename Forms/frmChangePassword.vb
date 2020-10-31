Public Class FrmChangePassword
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub FrmChangePassword_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 100%
    End Sub

    Private Sub FrmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 100%
        txtNewPassword.Text = ""
        txtOldPassword.Text = ""
        txtRetype.Text = ""

        txtOldPassword.Focus()

    End Sub

    Private Sub FrmChangePassword_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtOldPassword.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtOldPassword.Text = "" Then
            MsgBox("Please enter your old password!")
            txtOldPassword.Focus()
        ElseIf txtNewPassword.Text = "" Then
            MsgBox("Please enter your new password!")
            txtNewPassword.Focus()
        ElseIf txtRetype.Text = "" Then
            MsgBox("Please retype your new password!")
            txtRetype.Focus()
        ElseIf txtNewPassword.Text <> txtRetype.Text Then
            MessageBox.Show("The entered passwords are different!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRetype.Text = ""
            txtNewPassword.Focus()
            txtNewPassword.SelectAll()
        Else
            Dim user As New Login With {
                .LoginId = GV.CurrentUser.LoginId,
                .Password = txtOldPassword.Text
            }
            If user.Password <> GV.CurrentUser.Password Then
                MessageBox.Show("The entered passwords are different!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtRetype.Text = ""
                txtNewPassword.Focus()
                txtNewPassword.SelectAll()
            Else
                If user.ChangePassowrd(txtNewPassword.Text) Then
                    GV.CurrentUser.Password = user.Password
                    MsgBox("Password changed successfully!")
                    Me.Close()
                Else
                    MsgBox("Failed to change your password!")
                End If
            End If
        End If
    End Sub
End Class
