Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmManageDestinations
    Private Sub LoadAllDestinations()

        Dim query As String = "SELECT * FROM Destination ORDER BY Destination;"
        'Dim adapter As New SqlDataAdapter(query, ExClass.myConn)
        'Dim ds As New DataSet()
        'ds.Reset()



        'gridControl.DataSource = Nothing
        'adapter.Fill(ds)
        'gridControl.DataSource = ds.Tables(0)


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
            LoadAllDestinations()
        ElseIf e.Button.Properties.Caption = "New" Then
            frmAddDestination.destinationId = 0
            frmAddDestination.ShowDialog()
            If frmAddDestination.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllDestinations()
            End If
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditDestination()
        End If
    End Sub

    Private Sub EditDestination()
        Dim destinationId As Integer
        destinationId = gridView.GetFocusedRowCellValue("DestinationID")
        If destinationId <> 0 Then
            frmAddDestination.destinationId = destinationId
            frmAddDestination.ShowDialog()
            If frmAddDestination.DialogResult = Windows.Forms.DialogResult.OK Then
                LoadAllDestinations()
            End If
        End If
    End Sub
    Private Sub frmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.Wait(True)
        LoadAllDestinations()
        frmMain.Wait(False)
    End Sub

    Private Sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditDestination()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditDestination()
        End If
    End Sub

End Class
