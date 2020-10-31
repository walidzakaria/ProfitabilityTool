
Public Class FrmManageTourOperator
    Private Sub LoadAllTourOperators()

        Dim query As String = "SELECT * FROM TourOperator ORDER BY TourOperator;"

        Dim dt As DataTable = ExClass.QueryGet(query)
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
            LoadAllTourOperators()
        ElseIf e.Button.Properties.Caption = "New" Then
            AddNewOperator()
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditTourOperator()
        End If
    End Sub

    Private Sub AddNewOperator()
        FrmAddTourOperator.tourOperatorID = 0
        FrmAddTourOperator.ShowDialog()

        If FrmAddTourOperator.DialogResult = DialogResult.OK Then
            LoadAllTourOperators()
        End If
    End Sub

    Private Sub EditTourOperator()
        Dim tourOperatorID As Integer
        tourOperatorID = CInt(gridView.GetFocusedRowCellValue("TourOperatorID"))
        If tourOperatorID <> 0 Then
            FrmAddTourOperator.tourOperatorID = tourOperatorID
            FrmAddTourOperator.ShowDialog()
            If FrmAddTourOperator.DialogResult = DialogResult.OK Then
                LoadAllTourOperators()
            End If
        End If
    End Sub

    Private Sub FrmManageTourOperator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            AddNewOperator()
        End If
    End Sub
    Private Sub FrmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmMain.Wait(True)
        LoadAllTourOperators()
        FrmMain.Wait(False)
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditTourOperator()
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditTourOperator()
        End If
    End Sub

End Class
