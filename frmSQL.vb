Public Class frmSQL 

    
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        meQuery.EditValue = Nothing
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        If meQuery.EditValue = "" Then
            Exit Sub
        End If
        Dim query As String = meQuery.EditValue

        If query.ToLower Like "*select*" Then
            Dim dt As New DataTable()
            Try
                dt = ExClass.QueryGet(query)
                gridControl1.DataSource = Nothing

                gridControl1.DataSource = dt
                gridView1.PopulateColumns()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            
        Else
            ExClass.QuerySet(query)
        End If
    End Sub

    Private Sub frmSQL_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnRun.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class