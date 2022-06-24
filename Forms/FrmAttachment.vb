Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010
Imports System.IO

Public Class FrmAttachment
    Public Shared BookingId As Long
    Private Sub FrmAttachment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        Select Case e.Button.Properties.Caption
            Case "Close"
                Me.Close()
            Case "Delete"
                DeleteFile()
            Case "Paste"
                PasteAttachment()
            Case "Browse"
                BrowseFile()
            Case "View"
                ViewAttachment()
        End Select
    End Sub

    Private Sub ViewAttachment()
        Dim attachmentId = CInt(GridView1.GetFocusedRowCellValue("AttachmentID"))
        If attachmentId > 0 Then
            Dim fileData = Attachment.GetAttachmentFile(attachmentId)

            Dim fileName = GridView1.GetFocusedRowCellValue("AttachmentName").ToString
            Dim filePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            filePath = $"{filePath}\PR_tool\"
            If Not Directory.Exists(filePath) Then
                Directory.CreateDirectory(filePath)
            End If
            Dim attachmentName As String = $"{filePath}attachment.{fileName.Split("."c)(fileName.Split("."c).Length - 1)}"
            If File.Exists(attachmentName) Then
                File.Delete(attachmentName)
            End If
            My.Computer.FileSystem.WriteAllBytes(attachmentName, fileData, False)
            Process.Start(attachmentName)

        End If

    End Sub

    Private Sub PasteAttachment()
        Dim files = Clipboard.GetFileDropList()
        For Each file In files
            Dim fs As FileStream = New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim fileBytes(0 To fs.Length - 1) As Byte
            fs.Read(fileBytes, 0, fs.Length)

            Dim newAttachment = New Attachment(0, BookingId, System.IO.Path.GetFileName(file), fileBytes, GV.CurrentUser.LoginId)
            newAttachment.Save()
            fs.Close()
        Next
        LoadData()
    End Sub

    Private Sub BrowseFile()
        If XtraOpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            Dim files = XtraOpenFileDialog1.FileNames
            For Each file In files
                Dim fs As FileStream = New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Dim fileBytes(0 To fs.Length - 1) As Byte
                fs.Read(fileBytes, 0, fs.Length)

                Dim newAttachment = New Attachment(0, BookingId, System.IO.Path.GetFileName(file), fileBytes, GV.CurrentUser.LoginId)
                newAttachment.Save()
                fs.Close()
            Next
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        Dim dt = Attachment.GetByBooking(BookingId)
        GridControl1.DataSource = dt
    End Sub
    Private Sub DeleteFile()
        Dim diaResult As DialogResult
        Dim attachmentId As Integer
        attachmentId = CInt(GridView1.GetFocusedRowCellValue("AttachmentID"))
        If attachmentId <= 0 Then Return
        diaResult = XtraMessageBox.Show("Are you sure you want to delete this file?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If diaResult = DialogResult.Yes Then
            Attachment.Delete(attachmentId)
            LoadData()
        End If

    End Sub

    Private Sub FrmAttachment_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each file In files
            Dim fs As FileStream = New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim fileBytes(0 To fs.Length - 1) As Byte
            fs.Read(fileBytes, 0, fs.Length)

            Dim newAttachment = New Attachment(0, BookingId, System.IO.Path.GetFileName(file), fileBytes, GV.CurrentUser.LoginId)
            newAttachment.Save()
            fs.Close()
        Next
        LoadData()
    End Sub

    Private Sub FrmAttachment_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub FrmAttachment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            If e.KeyCode = Keys.V Then
                PasteAttachment()
            ElseIf e.KeyCode = Keys.O Then
                BrowseFile()
            End If
        End If
    End Sub
End Class