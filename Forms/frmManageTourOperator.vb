Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmManageTourOperator
    Private Sub LoadAllTourOperators()

        Dim query As String = "SELECT * FROM TourOperator ORDER BY TourOperator;"

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
            LoadAllTourOperators()
        ElseIf e.Button.Properties.Caption = "New" Then
            AddNewOperator()
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditTourOperator()
        End If
    End Sub

    Private Sub AddNewOperator()
        frmAddTourOperator.tourOperatorID = 0
        frmAddTourOperator.ShowDialog()

        If frmAddTourOperator.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadAllTourOperators()
        End If
    End Sub

    Private Sub EditTourOperator()
        Dim tourOperatorID As Integer
        tourOperatorID = gridView.GetFocusedRowCellValue("TourOperatorID")
        If tourOperatorID <> 0 Then
            frmAddTourOperator.tourOperatorID = tourOperatorID
            frmAddTourOperator.ShowDialog()
            If frmAddTourOperator.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllTourOperators()
            End If
        End If
    End Sub

    Private Sub frmManageTourOperator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            AddNewOperator()
        End If
    End Sub
    Private Sub frmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.Wait(True)
        LoadAllTourOperators()
        frmMain.Wait(False)
    End Sub

    Private Sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditTourOperator()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditTourOperator()
        End If
    End Sub

End Class
