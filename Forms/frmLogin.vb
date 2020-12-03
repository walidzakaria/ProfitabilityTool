Imports DevExpress.XtraEditors
Public Class FrmLogin

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        If TxtUserName.Text = "" Then
            XtraMessageBox.Show("Please enter username!")
            TxtUserName.Focus()
            Exit Sub
        ElseIf TxtPassword.Text = "" Then
            XtraMessageBox.Show("Please enter password!")
            TxtPassword.Focus()
            Exit Sub
        End If

        Dim user As New Login With {
            .Username = TxtUserName.Text,
            .Password = TxtPassword.Text
        }

        Dim validUser As Boolean
        validUser = user.ValidLogin()

        If user.IsLocked Then
            XtraMessageBox.Show("The entered user is had been locked, please contact the administrator!")
        ElseIf Not validUser Then
            XtraMessageBox.Show("Invalid Login!")
        ElseIf Not user.Active Then
            XtraMessageBox.Show("The entered user is deactivated!")
        Else
            LblLoading.Visible = True
            Application.DoEvents()

            GV.CurrentUser = user
            FrmMain.FillRibbonDestinations()
            FrmMain.bhUsername.Caption = String.Format("<b><color=0, 0, 255>{0}</color></b>", GV.CurrentUser.Username)
            FrmMain.biLoginTime.Caption = String.Format("Login time: <b><color=0, 0, 255>{0}</color></b>", Now.ToString("HH:mm"))

            ExClass.Authorize(GV.CurrentUser.Authority)
            FrmMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FrmLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 100%
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        LblLoading.Visible = False
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblLoading.Visible = False
        TxtUserName.Text = ""
        TxtPassword.Text = ""
    End Sub

    Private Sub FrmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TxtUserName.Focus()
    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter AndAlso TxtUserName.Text <> "" AndAlso TxtPassword.Text <> "" Then
            e.Handled = True
            BtnOK.PerformClick()
        ElseIf e.KeyCode = Keys.Up Then
            TxtUserName.Focus()
            TxtUserName.SelectAll()
        ElseIf e.KeyCode = Keys.Down Then
            BtnOK.Focus()
        End If
    End Sub

    Private Sub TxtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUserName.KeyDown
        If e.KeyCode = Keys.Down Then
            TxtPassword.Focus()
            TxtPassword.SelectAll()
        End If
    End Sub
End Class