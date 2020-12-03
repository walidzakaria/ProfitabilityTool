Imports DevExpress.XtraEditors
Public Class FrmSQL

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        MeQuery.EditValue = Nothing
    End Sub

    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles BtnRun.Click
        If CStr(MeQuery.EditValue) = "" Then
            Exit Sub
        End If
        Dim query As String = CStr(MeQuery.EditValue)

        If query.ToLower Like "*select*" Then
            Dim dt As DataTable
            Try
                dt = ExClass.QueryGet(query)
                GridControl1.DataSource = Nothing

                GridControl1.DataSource = dt
                GridView1.PopulateColumns()
            Catch ex As Exception
                XtraMessageBox.Show(ex.ToString)
            End Try

        Else
            ExClass.QuerySet(query)
        End If
    End Sub

    Private Sub FrmSQL_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            BtnRun.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class