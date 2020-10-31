Imports DevExpress.XtraEditors

Partial Public Class FrmAddCurrency

    Public Shared currencyId As Integer = 0
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub FrmAddCurrency_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveCurrency()
        ElseIf e.KeyCode = Keys.Escape Then
            CloseCurrency()
        End If
    End Sub
    Private Sub FrmAddCurrency_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If currencyId = 0 Then
            TxtCurrency.EditValue = Nothing
            TxtRate.EditValue = Nothing
            DeEffectiveDate.EditValue = Today

            labelControl.Text = "Add Currency"
        Else
            labelControl.Text = "Edit Currency"
            RecallCurrency(currencyId)
        End If
    End Sub

    Private Sub RecallCurrency(ByVal currencyId As Integer)
        Dim currency As New Currency With {
            .CurrencyId = currencyId
        }
        If currency.GetById() Then
            TxtCurrency.EditValue = currency.Currency
            TxtRate.EditValue = currency.Rate
            DeEffectiveDate.EditValue = currency.EffectiveDate
        End If

    End Sub

    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveCurrency()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            CloseCurrency()
        End If

    End Sub

    Private Sub FrmAddCurrency_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TxtCurrency.Focus()
        TxtCurrency.SelectAll()
    End Sub

    Private Sub CloseCurrency()
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub SaveCurrency()
        If DxValidationProvider1.Validate() Then
            Dim currency As New Currency With {
                .CurrencyId = currencyId,
                .Currency = TxtCurrency.EditValue.ToString.ToUpper,
                .Rate = CDec(Val(TxtRate.EditValue))
            }
            DeEffectiveDate.RefreshEditValue()
            currency.EffectiveDate = CDate(DeEffectiveDate.EditValue)
            currency.LoginID = GV.CurrentUser.LoginId

            If currency.SaveCurrency() Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class
