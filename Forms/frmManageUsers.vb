Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Public Class frmManageUsers

    Private Sub LoadAuthorityOptions()
        Dim dt As New DataTable()
        dt.Columns.Add("ID")
        dt.Columns.Add("Authority")
        dt.Rows.Add({"Admin", "Admin"})
        dt.Rows.Add({"DMC", "DMC"})
        dt.Rows.Add({"TO", "TO"})
        dt.Rows.Add({"RS", "RS"})
        RepositoryItemLookUpEdit1.DataSource = Nothing
        RepositoryItemLookUpEdit1.DataSource = dt
        RepositoryItemLookUpEdit1.ValueMember = "ID"
        RepositoryItemLookUpEdit1.DisplayMember = "Authority"

    End Sub
    Private Sub LoadAllUsers()

        Dim query As String = "SELECT * FROM Login ORDER BY Username;"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        gridControl.DataSource = dt
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub windowsUIButtonPanel_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick
        If e.Button.Properties.Caption = "Print" Then
            gridControl.ShowRibbonPrintPreview()
        ElseIf e.Button.Properties.Caption = "Close" Then
            Me.Close()
        ElseIf e.Button.Properties.Caption = "Reset" Then
            ResetUser()
        ElseIf e.Button.Properties.Caption = "New" Then
            frmAddUser.userId = 0
            frmAddUser.ShowDialog()
            If frmAddUser.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllUsers()
            End If
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditUser()
        ElseIf e.Button.Properties.Caption = "Options" Then
            If IsDBNull(gridView.GetFocusedRowCellValue("LoginID")) Then
                Exit Sub
            End If
            Dim loginId As Integer = gridView.GetFocusedRowCellValue("LoginID")
            frmUserSettings.userId = loginId
            frmUserSettings.ShowDialog()
        End If
    End Sub

    Private Sub EditUser()
        If IsDBNull(gridView.GetFocusedRowCellValue("LoginID")) Then
            Exit Sub
        End If
        Dim loginId As Integer = gridView.GetFocusedRowCellValue("LoginID")
        frmAddUser.userId = loginId
        frmAddUser.ShowDialog()
        If frmAddUser.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadAllUsers()
        End If
    End Sub
    Private Sub frmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.Wait(True)
        LoadAuthorityOptions()
        LoadAllUsers()

        frmMain.Wait(False)
    End Sub

    Private Sub ResetUser()
        Dim ID As Integer = 0

        If IsDBNull(gridView.GetFocusedRowCellValue("LoginID")) Then
            Exit Sub
        End If

        ID = gridView.GetFocusedRowCellValue("LoginID")
        Dim DiaR As DialogResult = MessageBox.Show("Are you sure you want to reset user password to be '123456'?", "Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DiaR = Windows.Forms.DialogResult.Yes Then
            Dim user As New Login()
            user.LoginId = ID
            If user.ResetPassword() Then
                MsgBox("Password was reset to '123456'!")
            Else
                MsgBox("Failed to reset password!")
            End If
        End If

    End Sub

    Private Sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditUser()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditUser()
        End If
    End Sub
End Class
