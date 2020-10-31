Public Class FrmSQL

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        meQuery.EditValue = Nothing
    End Sub

    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        If CStr(meQuery.EditValue) = "" Then
            Exit Sub
        End If
        Dim query As String = CStr(meQuery.EditValue)

        If query.ToLower Like "*select*" Then
            Dim dt As DataTable
            Try
                dt = ExClass.QueryGet(query)
                GridControl1.DataSource = Nothing

                GridControl1.DataSource = dt
                GridView1.PopulateColumns()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            ExClass.QuerySet(query)
        End If
    End Sub

    Private Sub FrmSQL_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnRun.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class