﻿Public Class frmAddUser 
    Public Shared userId As Integer = 0
    Private Sub Clear()
        txtUsername.Text = ""
        txtFullName.Text = ""
        txtEmail.Text = ""

        txtPassword.Text = ""
        txtRetype.Text = ""
        rgAuthority.SelectedIndex = 1
        LayoutControlItem4.Enabled = True
        LayoutControlItem5.Enabled = True

    End Sub

    Private Sub RecallUser(ByVal userId As Integer)
        Dim user As New Login()
        user.LoginId = userId
        user.GetById()

        txtUsername.EditValue = user.Username
        txtFullName.EditValue = user.FullName
        txtEmail.EditValue = user.Mail
        rgAuthority.EditValue = user.Authority
        rgActive.EditValue = user.Active
        LayoutControlItem4.Enabled = False
        LayoutControlItem5.Enabled = False

    End Sub

    Private Sub frmAddUser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        ElseIf e.Control And e.KeyCode = Keys.S Then
            If userId = 0 Then
                AddUser()
            Else
                UpdateUser()
            End If
        End If
    End Sub
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()

        If userId <> 0 Then
            RecallUser(userId)
        End If
    End Sub

    Private Sub frmAddUser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtUsername.Focus()
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            If userId = 0 Then
                AddUser()
            Else
                UpdateUser()
            End If

        ElseIf e.Button.Properties.Caption = "Cancel" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub

    Private Sub UpdateUser()
        If DxValidationProvider2.Validate() Then
            Dim user As New Login()
            user.Username = txtUsername.EditValue.ToString
            user.FullName = txtFullName.EditValue.ToString
            user.Password = txtPassword.EditValue.ToString
            user.Mail = txtEmail.EditValue.ToString
            user.Authority = rgAuthority.EditValue.ToString
            user.Active = rgActive.EditValue
            user.LoginId = userId

            If Not user.UniqueUsername Then
                MsgBox("The entered username already exists, please select a unique username!")
            Else
                If user.Update Then
                    MsgBox(String.Format("User '{0}' has been updated successfully!", user.Username))
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Failed to update!")
                End If
            End If
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
            user.Active = rgActive.EditValue

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