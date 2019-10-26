Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Partial Public Class frmAddCurrency

    Public Shared currencyId As Integer = 0
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub frmAddCurrency_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveCurrency()
        ElseIf e.KeyCode = Keys.Escape Then
            CloseCurrency()
        End If
    End Sub
    Private Sub frmAddCurrency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        If currencyId = 0 Then
            txtCurrency.EditValue = Nothing
            txtRate.EditValue = Nothing
            deEffectiveDate.EditValue = Today

            labelControl.Text = "Add Currency"
        Else
            labelControl.Text = "Edit Currency"
            RecallCurrency(currencyId)
        End If
    End Sub

    Private Sub RecallCurrency(ByVal currencyId As Integer)
        Dim currency As New Currency()
        currency.CurrencyId = currencyId
        If currency.GetById() Then
            txtCurrency.EditValue = currency.Currency
            txtRate.EditValue = currency.Rate
            deEffectiveDate.EditValue = currency.EffectiveDate
        End If

    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveCurrency()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            CloseCurrency()
        End If

    End Sub

    Private Sub frmAddCurrency_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtCurrency.Focus()
        txtCurrency.SelectAll()
    End Sub

    Private Sub CloseCurrency()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub SaveCurrency()
        If DxValidationProvider1.Validate() Then
            Dim currency As New Currency()
            currency.CurrencyId = currencyId
            currency.Currency = txtCurrency.EditValue.ToString.ToUpper
            currency.Rate = Val(txtRate.EditValue)
            deEffectiveDate.RefreshEditValue()
            currency.EffectiveDate = deEffectiveDate.EditValue
            currency.LoginID = GV.CurrentUser.LoginId
            
            If currency.SaveCurrency() Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class
