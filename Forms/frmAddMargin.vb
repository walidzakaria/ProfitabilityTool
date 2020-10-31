Imports DevExpress.XtraEditors

Partial Public Class FrmAddMargin

    Public Shared marginId As Integer = 0
    Public Shared marginCloned As Boolean = False
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub FillDestinations()
        Dim query As String = "SELECT * FROM Destination ORDER BY Destination;"
        Dim dt As DataTable
        dt = ExClass.QueryGet(query)
        LuDestination.Properties.DataSource = Nothing
        LuDestination.Properties.DataSource = dt
        LuDestination.Properties.DisplayMember = "Destination"
        LuDestination.Properties.ValueMember = "DestinationID"

    End Sub

    Private Sub FillTourOperators()
        Dim query As String = "SELECT * FROM TourOperator;"
        Dim dt As DataTable
        dt = ExClass.QueryGet(query)
        LuTourOperator.Properties.DataSource = Nothing
        LuTourOperator.Properties.DataSource = dt
        LuTourOperator.Properties.DisplayMember = "TourOperator"
        LuTourOperator.Properties.ValueMember = "TourOperatorID"

    End Sub

    Private Sub FrmAddMargin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveMargin()
        ElseIf e.KeyCode = Keys.Escape Then
            CloseMargin()
        End If
    End Sub
    Private Sub FrmAddDestination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDestinations()
        FillTourOperators()
        If marginId = 0 Then
            LuDestination.EditValue = Nothing
            LuTourOperator.EditValue = Nothing
            TxtMarginFrom.EditValue = Nothing
            TxtMarginTo.EditValue = Nothing
            TxtDifferenceFrom.EditValue = Nothing
            TxtDifferenceTo.EditValue = Nothing
            DeEffectiveDate.EditValue = Today

            labelControl.Text = "Add Margin"
        Else
            labelControl.Text = "Edit Margin"
            RecallMargin(marginId)
        End If
    End Sub

    Private Sub RecallMargin(ByVal marginId As Integer)
        Dim margin As New Margin With {
            .MarginId = marginId
        }
        If margin.GetById() Then
            LuDestination.EditValue = margin.DestinationId
            LuTourOperator.EditValue = margin.TourOperatorId
            TxtMarginFrom.EditValue = margin.MarginFrom.ToString
            TxtMarginTo.EditValue = margin.MarginTo.ToString
            TxtDifferenceFrom.EditValue = margin.DifferenceFrom.ToString
            TxtDifferenceTo.EditValue = margin.DifferenceTo.ToString
            DeEffectiveDate.EditValue = margin.EffectiveDate

        End If
    End Sub

    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveMargin()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            CloseMargin()
        End If

    End Sub

    Private Sub FrmAddMargin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LuDestination.Focus()
        LuDestination.SelectAll()
    End Sub

    Private Sub CloseMargin()
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub SaveMargin()
        If DxValidationProvider1.Validate() Then
            Dim margin As New Margin With {
                .MarginId = marginId,
                .DestinationId = CInt(LuDestination.EditValue),
                .TourOperatorId = CInt(LuTourOperator.EditValue),
                .MarginFrom = CSng(Val(TxtMarginFrom.EditValue)),
                .MarginTo = CSng(Val(TxtMarginTo.EditValue)),
                .DifferenceFrom = CSng(Val(TxtDifferenceFrom.EditValue)),
                .DifferenceTo = CSng(Val(TxtDifferenceTo.EditValue))
            }
            DeEffectiveDate.RefreshEditValue()
            margin.EffectiveDate = CDate(DeEffectiveDate.EditValue)

            If margin.SaveMargin() Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class
