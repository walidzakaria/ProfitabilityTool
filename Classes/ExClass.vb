Imports System.Data.SqlClient


Public Class ExClass
    Public Shared myConn As New SqlConnection("Data Source=Walid-PC\Master;Initial Catalog=YT_DB;User ID=UserConnect;Password=wwzzaa")
    'Public Shared myConn As New SqlConnection("workstation id=profitability.mssql.somee.com;packet size=4096;user id=walidpiano_SQLLogin_1;pwd=dwvw5bcqc3;data source=profitability.mssql.somee.com;persist security info=False;initial catalog=profitability")

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

    Public Shared Sub Authorize(ByVal userType As String)

        Select Case userType
            Case "Admin"
                With frmMain
                    .RibbonPageGroup1.Visible = True
                    .btnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnJunk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .brnCanceled.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnMatching.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .RibbonPageGroup5.Visible = True

                    .bcPendingDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcPendingDmc.Checked = True
                    .bcFixedDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcFixedDmc.Checked = True
                    .bcPendingTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcPendingTo.Checked = True
                    .bcFixedTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcFixedTo.Checked = True
                    .btnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
                    .btnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnAddNewUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnDestination.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnTO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnManageMargin.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End With
                With frmEdit
                    .windowsUIButtonPanelMain.Buttons(2).Properties.Enabled = True
                    .windowsUIButtonPanelMain.Buttons(3).Properties.Enabled = True
                End With
            Case "RS"
                With frmMain
                    .RibbonPageGroup1.Visible = True
                    .btnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnJunk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .brnCanceled.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnMatching.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .RibbonPageGroup5.Visible = True
                    .bcPendingDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcPendingDmc.Checked = True
                    .bcFixedDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcFixedDmc.Checked = True
                    .bcPendingTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcPendingTo.Checked = True
                    .bcFixedTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcFixedTo.Checked = True
                    .bcNewRecord.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcNewRecord.Checked = True

                    .btnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
                    .btnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnAddNewUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnDestination.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnTO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .btnManageMargin.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End With
                With frmEdit
                    .windowsUIButtonPanelMain.Buttons(2).Properties.Enabled = True
                    .windowsUIButtonPanelMain.Buttons(3).Properties.Enabled = True
                End With
            Case "DMC"
                With frmMain
                    .RibbonPageGroup1.Visible = False
                    .btnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnJunk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .brnCanceled.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnMatching.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .RibbonPageGroup5.Visible = False
                    .bcPendingDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcPendingDmc.Checked = True
                    .bcFixedDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcFixedDmc.Checked = True
                    .bcPendingTo.Checked = False
                    .bcPendingTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .bcFixedTo.Checked = False
                    .bcFixedTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .bcNewRecord.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcNewRecord.Checked = True

                    .btnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
                    .btnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnAddNewUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnDestination.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnTO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnManageMargin.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End With
                With frmEdit
                    .windowsUIButtonPanelMain.Buttons(2).Properties.Enabled = False
                    .windowsUIButtonPanelMain.Buttons(3).Properties.Enabled = False
                End With
            Case "TO"
                With frmMain
                    .RibbonPageGroup1.Visible = False
                    .btnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnJunk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .brnCanceled.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnMatching.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .RibbonPageGroup5.Visible = False

                    .bcPendingDmc.Checked = False
                    .bcPendingDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .bcFixedDmc.Checked = False
                    .bcFixedDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                    .bcPendingTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcPendingTo.Checked = True
                    .bcFixedTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .bcFixedTo.Checked = True
                    .bcNewRecord.Checked = False
                    .bcNewRecord.Visibility = DevExpress.XtraBars.BarItemVisibility.Never


                    .btnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
                    .btnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnAddNewUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnDestination.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnTO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnManageMargin.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End With
                With frmEdit
                    .windowsUIButtonPanelMain.Buttons(2).Properties.Enabled = False
                    .windowsUIButtonPanelMain.Buttons(3).Properties.Enabled = False

                End With
        End Select
    End Sub

End Class
