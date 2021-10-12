Imports DevExpress.XtraEditors
Public Class FrmManageSection
    Private Sub LoadAllSections()
        Dim userType As String
        If GV.CurrentUser.Authority = "SU TO" Then
            userType = "TO"
        Else
            userType = "DMC"
        End If
        Dim query As String = $"SELECT SectionID, Section, [Status]
                    FROM Section WHERE UserType = '{userType}'
                    ORDER BY Section;"

        Dim dt As DataTable = ExClass.QueryGet(query)
        GridControl.DataSource = dt
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub WindowsUIButtonPanel_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel.ButtonClick
        If e.Button.Properties.Caption = "Print" Then
            GridControl.ShowRibbonPrintPreview()
        ElseIf e.Button.Properties.Caption = "Close" Then
            Me.Close()
        ElseIf e.Button.Properties.Caption = "Refresh" Then
            LoadAllSections()
        ElseIf e.Button.Properties.Caption = "New" Then
            AddNewSection()
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditSection()
        ElseIf e.Button.Properties.Caption = "Delete" Then
            DeleteSection()
        End If
    End Sub

    Private Sub AddNewSection()

        FrmAddSection.SectionId = 0
        FrmAddSection.ShowDialog()
        If FrmAddSection.DialogResult = DialogResult.OK Then
            LoadAllSections()
        End If
    End Sub
    Private Sub EditSection()
        Dim sectionId As Integer
        sectionId = CInt(gridView.GetFocusedRowCellValue("SectionID"))
        If sectionId <> 0 Then
            FrmAddSection.SectionId = sectionId

            FrmAddSection.ShowDialog()
            If FrmAddSection.DialogResult = DialogResult.OK Then
                LoadAllSections()
            End If
        End If
    End Sub

    Private Sub DeleteSection()
        Dim sectionId As Integer
        sectionId = CInt(gridView.GetFocusedRowCellValue("SectionID"))
        If sectionId <> 0 Then
            Dim diaR As DialogResult = XtraMessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If diaR = DialogResult.Yes Then
                Dim section As New Section With {
                    .SectionId = sectionId
                }
                If section.DeleteById() Then
                    LoadAllSections()
                End If
            End If
        End If
    End Sub

    Private Sub FrmSectionMargin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            AddNewSection()
        End If
    End Sub
    Private Sub FrmManageSection_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmMain.Wait(True)
        LoadAllSections()
        FrmMain.Wait(False)
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditSection()
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditSection()
        End If
    End Sub
End Class
