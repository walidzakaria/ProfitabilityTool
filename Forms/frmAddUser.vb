Public Class frmAddUser 

    Private Sub Clear()
        txtUsername.Text = ""
        txtFullName.Text = ""
        txtEmail.Text = ""

        txtPassword.Text = ""
        txtRetype.Text = ""

        rgAuthority.SelectedIndex = 1
    End Sub
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()

    End Sub

    Private Sub frmAddUser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtUsername.Focus()
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            AddUser()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub

    Private Sub AddUser()

        If DxValidationProvider1.Validate() Then
            Dim user As New Login()
            user.Username = txtUsername.EditValue.ToString
            user.FullName = txtFullName.EditValue.ToString
            user.Password = txtPassword.EditValue.ToString
            user.Mail = txtEmail.EditValue.ToString
            user.Authority = rgAuthority.EditValue.ToString

            user.Active = True
            If Not user.UniqueUsername Then
                MsgBox("The entered username already exists, please select a unique username!")
            Else
                If user.Signup() Then
                    MsgBox(String.Format("User '{0}' has been signed up successfully!", user.Username))
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Failed to sign up!")
                End If
            End If
        End If

    End Sub
End Class