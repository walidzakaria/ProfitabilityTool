Public Class frmLogin 

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtUserName.Text = "" Then
            MsgBox("Please enter username!")
            txtUserName.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please enter password!")
            txtPassword.Focus()
        Else
            Dim user As New Login()
            user.Username = txtUserName.Text
            user.Password = txtPassword.Text

            If Not user.ValidLogin Then
                MsgBox("Invalid Login!")
            Else
                If Not user.Active Then
                    MsgBox("The entered user is blocked!")
                Else
                    lblLoading.Visible = True
                    Application.DoEvents()
                    GV.CurrentUser = user
                    frmMain.FillRibbonDestinations()
                    frmMain.bhUsername.Caption = String.Format("<b><color=0, 0, 255>{0}</color></b>", GV.CurrentUser.Username)
                    frmMain.biLoginTime.Caption = String.Format("Login time: <b><color=0, 0, 255>{0}</color></b>", Now.ToString("HH:mm"))

                    ExClass.Authorize(GV.CurrentUser.Authority)
                    frmMain.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 100%
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        lblLoading.Visible = False
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblLoading.Visible = False
        txtUserName.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtUserName.Focus()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter AndAlso txtUserName.Text <> "" AndAlso txtPassword.Text <> "" Then
            e.Handled = True
            btnOK.PerformClick()
        ElseIf e.KeyCode = Keys.Up Then
            txtUserName.Focus()
            txtUserName.SelectAll()
        ElseIf e.KeyCode = Keys.Down Then
            btnOK.Focus()
        End If
    End Sub

    Private Sub txtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Down Then
            txtPassword.Focus()
            txtPassword.SelectAll()
        End If
    End Sub
End Class