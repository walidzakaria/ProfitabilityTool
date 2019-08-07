Imports System.Data.SqlClient
Public Class ExClass
    Public Shared myConn As New SqlConnection("Data Source=Walid-PC\Master;Initial Catalog=YT_DB;User ID=UserConnect;Password=wwzzaa")

    Public Shared Function QuerySet(ByVal query As String) As String
        Dim result As String
        Using cmd = New SqlCommand(query, myConn)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            Try
                cmd.ExecuteNonQuery()
                result = "True"
            Catch ex As Exception
                result = ex.ToString
            End Try
            myConn.Close()
        End Using

        Return result
    End Function

    Public Shared Function QueryGet(ByVal query As String)
        Dim result As New DataTable()

        Using cmd = New SqlCommand(query, myConn)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            Using dr As SqlDataReader = cmd.ExecuteReader()
                result.Load(dr)

            End Using
            myConn.Close()
        End Using

        Return result
    End Function
End Class
