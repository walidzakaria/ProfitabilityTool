Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmManageMargin
    Private Sub LoadAllMargins()

        Dim query As String = "SELECT Ma.MarginID, De.Destination, Ma.MarginFrom, Ma.MarginTo, Ma.EffectiveDate" _
                              & " FROM Margin Ma, Destination De" _
                              & " WHERE Ma.DestinationID = De.DestinationID;"

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
            LoadAllMargins()
        ElseIf e.Button.Properties.Caption = "New" Then
            frmAddMargin.marginId = 0
            frmAddMargin.ShowDialog()
            If frmAddMargin.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllMargins()
            End If
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditMargin()
        End If
    End Sub

    Private Sub EditMargin()
        Dim marginId As Integer
        marginId = gridView.GetFocusedRowCellValue("MarginID")
        If marginId <> 0 Then
            frmAddMargin.marginId = marginId

            frmAddMargin.ShowDialog()
            If frmAddMargin.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllMargins()
            End If
        End If
    End Sub
    Private Sub frmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.Wait(True)
        LoadAllMargins()
        frmMain.Wait(False)
    End Sub

    Private Sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditMargin()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditMargin()
        End If
    End Sub
End Class
