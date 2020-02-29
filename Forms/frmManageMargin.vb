Public Class frmManageMargin
    Private Sub LoadAllMargins()

        Dim query As String = "SELECT Ma.MarginID, De.Destination, TourOperator.TourOperator, Ma.MarginFrom, Ma.MarginTo, Ma.DifferenceFrom, Ma.DifferenceTo, Ma.EffectiveDate" _
                              & " FROM Margin Ma, Destination De, TourOperator" _
                              & " WHERE Ma.DestinationID = De.DestinationID AND Ma.TourOperatorID = TourOperator.TourOperatorID;"

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
            LoadAllMargins()
        ElseIf e.Button.Properties.Caption = "New" Then
            AddNewMargin()
        ElseIf e.Button.Properties.Caption = "Edit" Then
            EditMargin()
        ElseIf e.Button.Properties.Caption = "Delete" Then
            DeleteMargin()
        End If
    End Sub

    Private Sub AddNewMargin()
        frmAddMargin.marginId = 0
        frmAddMargin.ShowDialog()
        If frmAddMargin.DialogResult = DialogResult.OK Then
            LoadAllMargins()
        End If
    End Sub
    Private Sub EditMargin()
        Dim marginId As Integer
        marginId = CInt(gridView.GetFocusedRowCellValue("MarginID"))
        If marginId <> 0 Then
            frmAddMargin.marginId = marginId

            frmAddMargin.ShowDialog()
            If frmAddMargin.DialogResult = DialogResult.OK Then
                LoadAllMargins()
            End If
        End If
    End Sub

    Private Sub DeleteMargin()
        Dim marginId As Integer
        marginId = CInt(gridView.GetFocusedRowCellValue("MarginID"))
        If marginId <> 0 Then
            Dim diaR As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If diaR = DialogResult.Yes Then
                Dim margin As New Margin()
                margin.MarginId = marginId
                If margin.DeleteById() Then
                    LoadAllMargins()
                End If
            End If
        End If
    End Sub

    Private Sub frmManageMargin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            AddNewMargin()
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
