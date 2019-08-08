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

    Public Shared Function CalculateText(ByVal formula As String) As Single
        Dim result As Single = 0
        Dim newFormula As String = ""
        For Each i In formula
            If i = "x" Then
                newFormula &= "*"
            ElseIf i = "-" Or i = "+" Or i = "/" Or i = "*" Or i = "%" Or i = "." Or i = "(" Or i = ")" Then
                newFormula &= i
            ElseIf IsNumeric(i) Then
                newFormula &= i
            End If
        Next
        Dim SC As New MSScriptControl.ScriptControl
        newFormula = ReformPercentage(newFormula)
        SC.Language = "VBSCRIPT"
        Try
            result = Convert.ToSingle(SC.Eval(newFormula))
        Catch ex As Exception
        End Try

        Return result
    End Function

    Private Shared Function ReformPercentage(ByVal formula As String) As String
        Dim result As String = ""
        Dim splitter As Integer
        Dim sign As String = ""
        Dim firstPart As String
        Dim secondPart As String
        For Each i In formula
            If i = "%" Then
                For x = 0 To Len(result) - 1
                    If result(x) = "+" Or result(x) = "-" Or result(x) = "/" Or result(x) = "*" Then
                        splitter = x
                        sign = result(x)
                    End If
                Next
                firstPart = Left(result, splitter)
                secondPart = result.Substring(splitter + 1)
                If sign = "*" Or sign = "/" Then
                    secondPart = (Val(secondPart) / 100).ToString
                ElseIf sign = "-" Then
                    sign = "*"
                    secondPart = ((100 - Val(secondPart)) / 100).ToString
                ElseIf sign = "+" Then
                    sign = "*"
                    secondPart = (1 + (Val(secondPart)) / 100).ToString
                End If
                result = firstPart & sign & secondPart
            Else
                result &= i
            End If

        Next

        Return result
    End Function
End Class
