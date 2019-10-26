Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmCurrency
    Private Sub LoadAllCurrencies()

        Dim query As String = "SELECT Exchange.ExchangeID, Exchange.Currency, Exchange.Rate, Exchange.EffectiveDate, [Login].Username" _
                              & " FROM Exchange, Login" _
                              & " WHERE Exchange.LoginID = Login.LoginId"

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
        ElseIf e.Button.Properties.Caption = "Refresh" Then
            LoadAllCurrencies()
        ElseIf e.Button.Properties.Caption = "New" Then
            frmAddCurrency.currencyId = 0
            frmAddCurrency.ShowDialog()

            If frmAddCurrency.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllCurrencies()
            End If
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditCurrency()
        ElseIf e.Button.Properties.Caption = "Delete" Then
            DeleteCurrency()
        End If
    End Sub

    Private Sub EditCurrency()
        Dim currencyID As Integer
        currencyID = gridView.GetFocusedRowCellValue("ExchangeID")
        If currencyID <> 0 Then
            frmAddCurrency.currencyId = currencyID

            frmAddCurrency.ShowDialog()
            If frmAddCurrency.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllCurrencies()
            End If
        End If
    End Sub

    Private Sub DeleteCurrency()
        Dim currencyId As Integer
        currencyId = gridView.GetFocusedRowCellValue("ExchangeID")
        If currencyId <> 0 Then
            Dim diaR As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If diaR = Windows.Forms.DialogResult.Yes Then
                Dim currency As New Currency()
                currency.CurrencyId = currencyId
                If currency.DeleteById() Then
                    LoadAllCurrencies()
                End If
            End If
        End If
    End Sub
    Private Sub frmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.Wait(True)
        LoadAllCurrencies()
        frmMain.Wait(False)
    End Sub

    Private Sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditCurrency()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditCurrency()
        End If
    End Sub
End Class
