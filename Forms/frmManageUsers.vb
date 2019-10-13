Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Public Class frmManageUsers
    Dim usersCache As String

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
            frmAddUser.ShowDialog()
            If frmAddUser.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllUsers()
            End If
        ElseIf e.Button.Properties.Caption = "Save" Then
            UpdateUsers()
            LoadAllUsers()
        End If
    End Sub
    Private Sub frmManageAllUsers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If usersCache <> "" Then
            Dim diaResult As DialogResult
            diaResult = MessageBox.Show("Want to save changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaResult = Windows.Forms.DialogResult.Yes Then
                UpdateUsers()
            ElseIf diaResult = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.Wait(True)
        LoadAuthorityOptions()
        LoadAllUsers()
        usersCache = ""
        frmMain.Wait(False)
    End Sub

    Private Sub gridView_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gridView.RowUpdated
        UpdateCache()
    End Sub

    Private Sub UpdateCache()
        Dim loginID As Integer
        Dim username, fullName, email, authority As String
        Dim active As Short
        gridView.ValidateEditor()
        'gridView.UpdateCurrentRow()
        loginID = gridView.GetFocusedRowCellValue("LoginID")
        username = gridView.GetFocusedRowCellValue("Username")
        fullName = gridView.GetFocusedRowCellValue("FullName")
        email = gridView.GetFocusedRowCellValue("Mail").ToString.ToLower
        email = StrConv(email, VbStrConv.ProperCase)
        authority = gridView.GetFocusedRowCellValue("Authority")
        active = gridView.GetFocusedRowCellValue("Active")
        usersCache &= String.Format("UPDATE Login SET Username = '{0}', FullName = '{1}', Mail = '{2}', Authority = '{3}', Active = {4} WHERE LoginID = {5}; ", _
                                     username, fullName, email, authority, active, loginID)

    End Sub

    Private Sub UpdateUsers()
        gridView.PostEditor()
        UpdateCache()
        If usersCache <> "" Then
            frmMain.Wait(True)
            Dim result As String
            result = ExClass.QuerySet(usersCache)
            If result <> "True" Then
                frmMain.Wait(False)
                MsgBox(result)
            End If
            usersCache = ""
            frmMain.Wait(False)
        End If

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
End Class
