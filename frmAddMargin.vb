Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Partial Public Class frmAddMargin

    Public Shared marginId As Integer = 0
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub FillDestinations()
        Dim query As String = "SELECT * FROM Destination ORDER BY Destination;"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        luDestination.Properties.DataSource = Nothing
        luDestination.Properties.DataSource = dt
        luDestination.Properties.DisplayMember = "Destination"
        luDestination.Properties.ValueMember = "DestinationID"

    End Sub
    Private Sub frmAddDestination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDestinations()
        If marginId = 0 Then
            luDestination.EditValue = Nothing
            txtMarginFrom.EditValue = Nothing
            txtMarginTo.EditValue = Nothing
            deEffectiveDate.EditValue = Today

            labelControl.Text = "Add Margin"
        Else
            labelControl.Text = "Edit Margin"
            RecallMargin(marginId)
        End If
    End Sub

    Private Sub RecallMargin(ByVal marginId As Integer)
        Dim margin As New Margin()
        margin.MarginId = marginId
        If margin.GetById() Then
            luDestination.EditValue = margin.DestinationId
            txtMarginFrom.EditValue = margin.MarginFrom.ToString
            txtMarginTo.EditValue = margin.MarginTo.ToString
            deEffectiveDate.EditValue = margin.EffectiveDate

        End If
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            If DxValidationProvider1.Validate() Then
                Dim margin As New Margin()
                margin.MarginId = marginId
                margin.DestinationId = luDestination.EditValue
                margin.MarginFrom = Val(txtMarginFrom.EditValue)
                margin.MarginTo = Val(txtMarginTo.EditValue)
                deEffectiveDate.RefreshEditValue()
                margin.EffectiveDate = deEffectiveDate.EditValue

                If margin.SaveMargin() Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If

    End Sub

End Class
