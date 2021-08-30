Imports DevExpress.XtraEditors
Public Class FrmAddUser
    Public Shared userId As Integer = 0
    Private Sub Clear()
        TxtUsername.Text = ""
        TxtFullName.Text = ""
        TxtEmail.Text = ""

        TxtPassword.Text = ""
        TxtRetype.Text = ""
        If GV.CurrentUser.Authority = "Admin" Then
            RgAuthority.SelectedIndex = 1
        ElseIf GV.CurrentUser.Authority = "SU DMC" Then
            RgAuthority.SelectedIndex = 2
        ElseIf GV.CurrentUser.Authority = "SU TO" Then
            RgAuthority.SelectedIndex = 3
        End If
        LayoutControlItem4.Enabled = True
        LayoutControlItem5.Enabled = True

    End Sub

    Private Sub RecallUser(ByVal userId As Integer)
        Dim user As New Login With {
            .LoginId = userId
        }
        user.GetById()

        TxtUsername.EditValue = user.Username
        TxtFullName.EditValue = user.Fullname
        TxtEmail.EditValue = user.Mail
        RgAuthority.EditValue = user.Authority
        RgActive.EditValue = user.Active
        RgLocked.EditValue = user.IsLocked
        LayoutControlItem4.Enabled = False
        LayoutControlItem5.Enabled = False

    End Sub

    Private Sub FrmAddUser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
        ElseIf e.Control And e.KeyCode = Keys.S Then
            If userId = 0 Then
                AddUser()
            Else
                UpdateUser()
            End If
        End If
    End Sub
    Private Sub FrmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        If GV.CurrentUser.Authority = "Admin" Then
            For x As Integer = 0 To RgAuthority.Properties.Items.Count - 1
                RgAuthority.Properties.Items(x).Enabled = True
            Next
        ElseIf GV.CurrentUser.Authority = "SU DMC" Then
            RgAuthority.Properties.Items(0).Enabled = False
            RgAuthority.Properties.Items(1).Enabled = False
            RgAuthority.Properties.Items(3).Enabled = False
            RgAuthority.Properties.Items(5).Enabled = False
        ElseIf GV.CurrentUser.Authority = "SU TO" Then
            RgAuthority.Properties.Items(0).Enabled = False
            RgAuthority.Properties.Items(1).Enabled = False
            RgAuthority.Properties.Items(2).Enabled = False
            RgAuthority.Properties.Items(4).Enabled = False
        End If
        If userId <> 0 Then
            RecallUser(userId)
        End If
    End Sub

    Private Sub FrmAddUser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TxtUsername.Focus()
    End Sub

    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            If userId = 0 Then
                AddUser()
            Else
                UpdateUser()
            End If

        ElseIf e.Button.Properties.Caption = "Cancel" Then
            Me.DialogResult = DialogResult.Cancel
        End If

    End Sub

    Private Sub UpdateUser()
        If DxValidationProvider2.Validate() Then
            Dim user As New Login With {
                .Username = TxtUsername.EditValue.ToString,
                .Fullname = TxtFullName.EditValue.ToString,
                .Password = TxtPassword.EditValue.ToString,
                .Mail = TxtEmail.EditValue.ToString,
                .Authority = RgAuthority.EditValue.ToString,
                .Active = CBool(RgActive.EditValue),
                .IsLocked = CBool(RgLocked.EditValue)
            }
            If Not user.IsLocked Then
                user.InvalidLogins = 0
            End If
            user.LoginId = userId

            If Not user.UniqueUsername Then
                XtraMessageBox.Show("The entered username already exists, please select a unique username!")
            Else
                If user.Update Then
                    XtraMessageBox.Show(String.Format("User '{0}' has been updated successfully!", user.Username))
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    XtraMessageBox.Show("Failed to update!")
                End If
            End If
        End If

    End Sub

    Private Sub AddUser()

        If DxValidationProvider1.Validate() Then
            Dim user As New Login With {
                .Username = TxtUsername.EditValue.ToString,
                .Fullname = TxtFullName.EditValue.ToString,
                .Password = TxtPassword.EditValue.ToString,
                .Mail = TxtEmail.EditValue.ToString,
                .Authority = RgAuthority.EditValue.ToString,
                .Active = CBool(RgActive.EditValue),
                .IsLocked = CBool(RgLocked.EditValue),
                .InvalidLogins = 0
            }

            If Not user.UniqueUsername Then
                XtraMessageBox.Show("The entered username already exists, please select a unique username!")
            Else
                If user.Signup() Then
                    XtraMessageBox.Show(String.Format("User '{0}' has been signed up successfully!", user.Username))
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    XtraMessageBox.Show("Failed to sign up!")
                End If
            End If
        End If

    End Sub

End Class