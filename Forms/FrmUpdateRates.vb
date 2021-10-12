Public Class FrmUpdateRates
    Dim ToCancel As Boolean
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub peImage_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmUpdateRates_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 100%
        ProgressBarControl1.EditValue = 0
        ProgressBarControl1.Properties.ShowTitle = True

        ProgressBarControl1.Properties.Step = 1
        ToCancel = False

    End Sub

    Private Sub UpdateBulk()

        Dim inputData As String = Clipboard.GetText()
        Dim rowArr() As String = Split(inputData, vbCrLf)
        Dim rowList = rowArr.Where(Function(r) Len(r) > 0).Select(Function(r) CreateBooking(r)) _
                            .Distinct.ToList()

        Dim totalRows As Integer = rowList.Count

        Dim done As Integer
        Dim success As Integer
        Dim failed As Integer


        ProgressBarControl1.Properties.Maximum = totalRows

        For Each item As Tuple(Of String, Double) In rowList
            If ToCancel Then
                Exit For
            End If

            If Update(item) Then
                success += 1
            Else
                failed += 1
            End If
            done += 1

            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()

            labelStatus.Text = $"{done} processed of {totalRows}"
            labelSuccess.Text = $"Total success {success}"
            labelFailure.Text = $"Total failed {failed}"
            Application.DoEvents()
        Next
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ToCancel = True
    End Sub

    Private Sub FrmProgress_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        UpdateBulk()
    End Sub

    Private Function CreateBooking(inputText As String) As Tuple(Of String, Double)
        Dim lineArray() As String = Split(inputText, vbTab)
        Dim reference As String = lineArray(0)
        Dim rate As Double
        If reference.Length = 9 Then
            rate = CDbl(lineArray(2))
        Else
            rate = CDbl(lineArray(1))
        End If
        Return New Tuple(Of String, Double)(reference, rate)
    End Function

    Public Function Update(booking As Tuple(Of String, Double)) As Boolean
        Dim result As Boolean
        Dim query As String
        Dim loginId As Integer = GV.CurrentUser.LoginId

        query = String.Format($"EXEC dbo.UpdateBooking '{booking.Item1}', {booking.Item2};")
        result = ExClass.QuerySet(query) = "True"

        Return result
    End Function
End Class
