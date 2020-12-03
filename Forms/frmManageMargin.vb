Imports DevExpress.XtraEditors
Public Class FrmManageMargin
    Private Sub LoadAllMargins()

        Dim query As String = "SELECT Ma.MarginID, De.Destination, TourOperator.TourOperator, Ma.MarginFrom, Ma.MarginTo, Ma.DifferenceFrom, Ma.DifferenceTo, Ma.EffectiveDate" _
                              & " FROM Margin Ma, Destination De, TourOperator" _
                              & " WHERE Ma.DestinationID = De.DestinationID AND Ma.TourOperatorID = TourOperator.TourOperatorID;"

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
        FrmAddMargin.marginId = 0
        FrmAddMargin.ShowDialog()
        If FrmAddMargin.DialogResult = DialogResult.OK Then
            LoadAllMargins()
        End If
    End Sub
    Private Sub EditMargin()
        Dim marginId As Integer
        marginId = CInt(gridView.GetFocusedRowCellValue("MarginID"))
        If marginId <> 0 Then
            FrmAddMargin.marginId = marginId

            FrmAddMargin.ShowDialog()
            If FrmAddMargin.DialogResult = DialogResult.OK Then
                LoadAllMargins()
            End If
        End If
    End Sub

    Private Sub DeleteMargin()
        Dim marginId As Integer
        marginId = CInt(gridView.GetFocusedRowCellValue("MarginID"))
        If marginId <> 0 Then
            Dim diaR As DialogResult = xtraMessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If diaR = DialogResult.Yes Then
                Dim margin As New Margin With {
                    .MarginId = marginId
                }
                If margin.DeleteById() Then
                    LoadAllMargins()
                End If
            End If
        End If
    End Sub

    Private Sub FrmManageMargin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            AddNewMargin()
        End If
    End Sub
    Private Sub FrmManageAllUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmMain.Wait(True)
        LoadAllMargins()
        FrmMain.Wait(False)
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        EditMargin()
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditMargin()
        End If
    End Sub
End Class
