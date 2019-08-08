Public Class frmManageUsers 
    Dim usersCache As String
    Private Sub LoadAllUsers()
        Dim query As String = "SELECT * FROM Login ORDER BY Username;"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        GridControl1.DataSource = dt
    End Sub

    Private Sub frmManageUsers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.Wait(True)
        LoadAllUsers()
        usersCache = ""
        frmMain.Wait(False)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim ID As Integer = 0

        If IsDBNull(GridView1.GetFocusedRowCellValue("LoginID")) Then
            Exit Sub
        End If

        ID = GridView1.GetFocusedRowCellValue("LoginID")
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

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        UpdateUsers()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Dim loginID As Integer
        Dim username, authority As String
        Dim active As Short
        loginID = GridView1.GetFocusedRowCellValue("LoginID")
        username = GridView1.GetFocusedRowCellValue("Username")
        authority = GridView1.GetFocusedRowCellValue("Authority")
        active = GridView1.GetFocusedRowCellValue("Active")
        usersCache &= String.Format("UPDATE Login SET Username = '{0}', Authority = '{1}', Active = {2} WHERE LoginID = {3}; ", _
                                     username, authority, active, loginID)

    End Sub

    Private Sub UpdateUsers()
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
End Class