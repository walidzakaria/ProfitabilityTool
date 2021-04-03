Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO
Imports System.Net

Public Class Form1
    Public Shared myConn As New SqlConnection()
    Public Shared ReleaseVersion As String
    Public Shared upToDate As Boolean
    Public Shared UpdateFiles() As String = {}
    Public WithEvents Downloader As WebClient
    Public Shared CurrentFile As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadConn()
        ReadUpdateData()

    End Sub

    Public Sub DownloadStart(fileName As String)
        LblProgress.Text = String.Format("Updating step {0} of {1}",
                                         CurrentFile.ToString, (UpdateFiles.Length + 1).ToString)
        Downloader = New WebClient
        Dim fileFullLink As String
        fileFullLink = String.Format("https://github.com/walidzakaria/ProfitabilityTool/raw/master/UpdateFiles/{0}", fileName)
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls Or SecurityProtocolType.Ssl3
        Downloader.DownloadFile(New Uri(fileFullLink), fileName)
        Me.Text = "PR Updater"
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) _
        Handles Downloader.DownloadProgressChanged
        Me.Text = String.Format("PR Updater - {0}", e.ProgressPercentage.ToString)
    End Sub

    Private Sub ReadConn()
        Dim fs As New FileStream("Profitability_Tool.exe.config", FileMode.Open, FileAccess.Read)
        Dim xmlDoc As XDocument = XDocument.Load(fs)

        Dim name = xmlDoc.Descendants(XName.Get("connectionStrings")).First().FirstNode().ToString
        Dim connectionString = System.Text.RegularExpressions.Regex.Match(name, "(?<=connectionString="")(.*)(?="" providerName)").Groups(0).Value
        myConn.ConnectionString = connectionString
    End Sub
    Public Shared Function QueryGet(ByVal query As String) As DataTable
        ' Get data from the database
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

    Private Sub ReadUpdateData()
        Dim dt As DataTable = QueryGet("SELECT * FROM VersionNumber;")
        upToDate = dt.Rows(0)(0).ToString.Equals(Application.ProductVersion)
        If Not IsDBNull(dt.Rows(0)(1)) AndAlso Not dt.Rows(0)(1).ToString = "" Then
            UpdateFiles = dt.Rows(0)(1).ToString.Split(";"c)
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not upToDate Then
            CurrentFile = 1
            DownloadStart("Profitability_Tool.exe")
            For Each f As String In UpdateFiles
                CurrentFile += 1
                DownloadStart(f)
            Next
        End If
        Shell("Profitability_Tool.exe")
        Application.Exit()
    End Sub
End Class
