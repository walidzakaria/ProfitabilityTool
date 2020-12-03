Imports DevExpress.XtraEditors
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
        TxtNewPassword.Text = ""
        TxtOldPassword.Text = ""
        TxtRetype.Text = ""

        TxtOldPassword.Focus()

    End Sub

    Private Sub FrmChangePassword_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TxtOldPassword.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If TxtOldPassword.Text = "" Then
            XtraMessageBox.Show("Please enter your old password!")
            TxtOldPassword.Focus()
        ElseIf TxtNewPassword.Text = "" Then
            XtraMessageBox.Show("Please enter your new password!")
            TxtNewPassword.Focus()
        ElseIf TxtRetype.Text = "" Then
            XtraMessageBox.Show("Please retype your new password!")
            TxtRetype.Focus()
        ElseIf TxtNewPassword.Text <> TxtRetype.Text Then
            XtraMessageBox.Show("The entered passwords are different!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtRetype.Text = ""
            TxtNewPassword.Focus()
            TxtNewPassword.SelectAll()
        Else
            Dim user As New Login With {
                .LoginId = GV.CurrentUser.LoginId,
                .Password = TxtOldPassword.Text
            }
            If user.Password <> GV.CurrentUser.Password Then
                XtraMessageBox.Show("The entered passwords are different!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRetype.Text = ""
                TxtNewPassword.Focus()
                TxtNewPassword.SelectAll()
            Else
                If user.ChangePassowrd(TxtNewPassword.Text) Then
                    GV.CurrentUser.Password = user.Password
                    XtraMessageBox.Show("Password changed successfully!")
                    Me.Close()
                Else
                    XtraMessageBox.Show("Failed to change your password!")
                End If
            End If
        End If
    End Sub
End Class
