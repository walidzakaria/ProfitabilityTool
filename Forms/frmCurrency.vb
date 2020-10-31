
Public Class FrmCurrency
    Private Sub LoadAllCurrencies()

        Dim query As String = "SELECT Exchange.ExchangeID, Exchange.Currency, Exchange.Rate, Exchange.EffectiveDate, [Login].Username" _
                              & " FROM Exchange, Login" _
                              & " WHERE Exchange.LoginID = Login.LoginId"

        Dim dt As DataTable
        dt = ExClass.QueryGet(query)
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
            LoadAllCurrencies()
        ElseIf e.Button.Properties.Caption = "New" Then
            AddNewCurrency()
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditCurrency()
        ElseIf e.Button.Properties.Caption = "Delete" Then
            DeleteCurrency()
        End If
    End Sub

    Private Sub EditCurrency()
        Dim currencyID As Integer
        currencyID = CInt(gridView.GetFocusedRowCellValue("ExchangeID"))
        If currencyID <> 0 Then
            FrmAddCurrency.currencyId = currencyID

            FrmAddCurrency.ShowDialog()
            If FrmAddCurrency.DialogResult = DialogResult.OK Then
                LoadAllCurrencies()
            End If
        End If
    End Sub

    Private Sub DeleteCurrency()
        Dim currencyId As Integer
        currencyId = CInt(gridView.GetFocusedRowCellValue("ExchangeID"))
        If currencyId <> 0 Then
            Dim diaR As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If diaR = DialogResult.Yes Then
                Dim currency As New Currency With {
                    .CurrencyId = currencyId
                }
                If currency.DeleteById() Then
                    LoadAllCurrencies()
                End If
            End If
        End If
    End Sub

    Private Sub AddNewCurrency()
        FrmAddCurrency.currencyId = 0
        FrmAddCurrency.ShowDialog()

        If FrmAddCurrency.DialogResult = DialogResult.OK Then
            LoadAllCurrencies()
        End If
    End Sub

    Private Sub FrmCurrency_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            AddNewCurrency()
        End If
    End Sub
    Private Sub FrmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmMain.Wait(True)
        LoadAllCurrencies()
        FrmMain.Wait(False)
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditCurrency()
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditCurrency()
        End If
    End Sub
End Class
