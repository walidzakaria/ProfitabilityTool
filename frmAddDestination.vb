Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Partial Public Class frmAddDestination

    Public Shared destinationId As Integer = 0
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub frmAddDestination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If destinationId = 0 Then
            txtCode.EditValue = Nothing
            txtDestination.EditValue = Nothing
            labelControl.Text = "Add Destination"
        Else
            labelControl.Text = "Edit Destination"
            RecallDestination(destinationId)
        End If
    End Sub

    Private Sub RecallDestination(ByVal destinationId As Integer)
        Dim destination As New Destination()
        destination.DestinationId = destinationId
        If destination.GetById() Then
            txtCode.EditValue = destination.DestinationCode
            txtDestination.EditValue = destination.Destination
        End If
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then

            If DxValidationProvider1.Validate() Then
                Dim destination As New Destination()
                destination.DestinationCode = txtCode.Text
                destination.Destination = txtDestination.Text
                destination.DestinationId = destinationId
                If destination.UniqueCode() Then
                    If destination.SaveDestination() Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                Else
                    MsgBox("Please enter a unique code")
                End If
            End If
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If

    End Sub

End Class
