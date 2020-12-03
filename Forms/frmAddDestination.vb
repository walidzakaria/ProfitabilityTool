Imports DevExpress.XtraEditors

Partial Public Class FrmAddDestination

    Public Shared destinationId As Integer = 0
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub FrmAddDestination_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveDestination()
        ElseIf e.KeyCode = Keys.Escape Then
            CloseDestination()
        End If
    End Sub
    Private Sub FrmAddDestination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If destinationId = 0 Then
            TxtCode.EditValue = Nothing
            TxtDestination.EditValue = Nothing
            labelControl.Text = "Add Destination"
        Else
            labelControl.Text = "Edit Destination"
            RecallDestination(destinationId)
        End If
    End Sub

    Private Sub RecallDestination(ByVal destinationId As Integer)
        Dim destination As New Destination With {
            .DestinationId = destinationId
        }
        If destination.GetById() Then
            TxtCode.EditValue = destination.DestinationCode
            TxtDestination.EditValue = destination.Destination
        End If
    End Sub

    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveDestination()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            CloseDestination()
        End If

    End Sub

    Private Sub FrmAddDestination_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TxtCode.Focus()
        TxtCode.SelectAll()
    End Sub

    Private Sub CloseDestination()
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub SaveDestination()
        If DxValidationProvider1.Validate() Then
            Dim destination As New Destination With {
                .DestinationCode = TxtCode.Text,
                .Destination = TxtDestination.Text,
                .DestinationId = destinationId
            }
            If destination.UniqueCode() Then
                If destination.SaveDestination() Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            Else
                XtraMessageBox.Show("Please enter a unique code!")
            End If
        End If
    End Sub
End Class
