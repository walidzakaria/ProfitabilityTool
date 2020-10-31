Public Class FrmManageDestinations
    Private Sub LoadAllDestinations()

        Dim query As String = "SELECT * FROM Destination ORDER BY Destination;"

        Dim dt As DataTable = ExClass.QueryGet(query)
        gridControl.DataSource = dt
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub WindowsUIButtonPanel_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick
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
        FrmAddDestination.destinationId = 0
        FrmAddDestination.ShowDialog()
        If FrmAddDestination.DialogResult = DialogResult.OK Then
            LoadAllDestinations()
        End If
    End Sub

    Private Sub EditDestination()
        Dim destinationId As Integer
        destinationId = CInt(gridView.GetFocusedRowCellValue("DestinationID"))
        If destinationId <> 0 Then
            FrmAddDestination.destinationId = destinationId
            FrmAddDestination.ShowDialog()
            If FrmAddDestination.DialogResult = DialogResult.OK Then
                LoadAllDestinations()
            End If
        End If
    End Sub

    Private Sub FrmManageDestinations_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            AddNewDestination()
        End If
    End Sub
    Private Sub FrmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmMain.Wait(True)
        LoadAllDestinations()
        FrmMain.Wait(False)
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditDestination()
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditDestination()
        End If
    End Sub

End Class
