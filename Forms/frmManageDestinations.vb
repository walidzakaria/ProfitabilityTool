Public Class frmManageDestinations
    Private Sub LoadAllDestinations()

        Dim query As String = "SELECT * FROM Destination ORDER BY Destination;"

        Dim dt As DataTable = ExClass.QueryGet(query)
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
            AddNewDestination()
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditDestination()
        End If
    End Sub

    Private Sub AddNewDestination()
        frmAddDestination.destinationId = 0
        frmAddDestination.ShowDialog()
        If frmAddDestination.DialogResult = DialogResult.OK Then
            LoadAllDestinations()
        End If
    End Sub

    Private Sub EditDestination()
        Dim destinationId As Integer
        destinationId = CInt(gridView.GetFocusedRowCellValue("DestinationID"))
        If destinationId <> 0 Then
            frmAddDestination.destinationId = destinationId
            frmAddDestination.ShowDialog()
            If frmAddDestination.DialogResult = DialogResult.OK Then
                LoadAllDestinations()
            End If
        End If
    End Sub

    Private Sub frmManageDestinations_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            AddNewDestination()
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
