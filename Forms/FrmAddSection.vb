Imports DevExpress.XtraEditors

Partial Public Class FrmAddSection

    Public Shared SectionId As Integer = 0
    Public Shared SectionCloned As Boolean = False
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub PopulateStatusMain()
        ' Load status rows
        Dim dt As New DataTable()
        dt.Columns.Add("ID")
        dt.Columns.Add("Status")
        dt.Rows.Add({"PENDING DMC", "PENDING DMC"})
        If GV.CurrentUser.Authority <> "TO" AndAlso GV.CurrentUser.Authority <> "SU TO" Then
            dt.Rows.Add({"FIXED DMC", "FIXED DMC"})
            dt.Rows.Add({"CANNOT FIX", "CANNOT FIX"})
        End If
        dt.Rows.Add({"PENDING T/O", "PENDING T/O"})
        If GV.CurrentUser.Authority <> "DMC" AndAlso GV.CurrentUser.Authority <> "RS" AndAlso GV.CurrentUser.Authority <> "SU DMC" Then
            dt.Rows.Add({"FIXED T/O", "FIXED T/O"})
        End If
        LuStatus.Properties.DataSource = Nothing
        LuStatus.Properties.DataSource = dt
        LuStatus.Properties.ValueMember = "ID"
        LuStatus.Properties.DisplayMember = "Status"

    End Sub

    Private Sub FrmAddMargin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveSection()
        ElseIf e.KeyCode = Keys.Escape Then
            CloseSection()
        End If
    End Sub
    Private Sub FrmAddDestination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateStatusMain()

        If SectionId = 0 Then
            LuStatus.EditValue = Nothing
            TxtSection.EditValue = Nothing
            labelControl.Text = "Add Section"
        Else
            labelControl.Text = "Edit Section"
            RecallSection(SectionId)
        End If
    End Sub

    Private Sub RecallSection(ByVal sectionId As Integer)
        Dim section As New Section With {
            .SectionId = sectionId
        }
        If section.GetById() Then
            LuStatus.EditValue = section.Status
            TxtSection.EditValue = section.Section
        End If
    End Sub

    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveSection()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            CloseSection()
        End If

    End Sub

    Private Sub FrmAddSection_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LuStatus.Focus()
        LuStatus.SelectAll()
    End Sub

    Private Sub CloseSection()
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub SaveSection()
        If DxValidationProvider1.Validate() Then
            Dim userType As String
            If GV.CurrentUser.Authority = "SU TO" Then
                userType = "TO"
            Else
                userType = "DMC"
            End If
            Dim section As New Section With {
                .SectionId = SectionId,
                .Section = TxtSection.EditValue.ToString,
                .Status = LuStatus.EditValue.ToString,
                .UserType = userType
            }

            If section.SaveSection() Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class
