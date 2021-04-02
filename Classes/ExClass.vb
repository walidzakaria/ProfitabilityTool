Imports System.Data.SqlClient


Public Class ExClass
    ''' <summary>
    ''' Generic methods and functions
    ''' </summary>

    Public Shared myConn As New SqlConnection(My.Settings.DatabaseConnection)
    'Public Shared myConn As New SqlConnection("Data Source=DESKTOP-5V3S1R4\MASTER;Initial Catalog=YT_DB;User ID=walid;Password=wwzzaa")
    'Public Shared myConn As New SqlConnection("workstation id=rs24profitabilitytool.mssql.somee.com;packet size=4096;user id=waliiid_SQLLogin_1;pwd=nhyb4lqews;data source=rs24profitabilitytool.mssql.somee.com;persist security info=False;initial catalog=rs24profitabilitytool")

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

    Public Shared Function CalculateText(ByVal formula As String) As Single
        ' Parse string value into suggested calculatation

        Dim result As Single = 0
        Dim newFormula As String = ""
        Dim i As String
        For x = 0 To Len(formula) - 1
            i = formula(x)
            If i = "-" Or i = "+" Or i = "/" Or i = "*" Or i = "%" Or i = "." Or i = "(" Or i = ")" Then
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
        ' Apply user profile authorization

        Select Case userType
            Case "Admin"
                With FrmMain
                    .RibbonPageGroup1.Visible = True
                    .BtnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnJunk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BrnCanceled.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnMatching.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .RibbonPageGroup5.Visible = True

                    .BcPendingDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcPendingDmc.Checked = True
                    .BcFixedDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcFixedDmc.Checked = True
                    .BcPendingTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcPendingTo.Checked = True
                    .BcFixedTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcFixedTo.Checked = True
                    .BtnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
                    .BtnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnDestination.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnManageCurrency.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnTO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnManageMargin.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .GridColumn7.Visible = True
                    .GridColumn7.OptionsColumn.AllowShowHide = True
                    .GridColumn8.Visible = True
                    .GridColumn8.OptionsColumn.AllowShowHide = True
                    .GridColumn12.Visible = True
                    .GridColumn12.OptionsColumn.AllowShowHide = True
                End With
                With FrmEdit
                    .windowsUIButtonPanelMain.Buttons(2).Properties.Enabled = True
                    .windowsUIButtonPanelMain.Buttons(3).Properties.Enabled = True
                    .LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    .LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    .LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                End With
            Case "RS"
                With FrmMain
                    .RibbonPageGroup1.Visible = True
                    .BtnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnJunk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BrnCanceled.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnMatching.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .RibbonPageGroup5.Visible = True
                    .BcPendingDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcPendingDmc.Checked = True
                    .BcFixedDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcFixedDmc.Checked = True
                    .BcPendingTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcPendingTo.Checked = True
                    .BcFixedTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcFixedTo.Checked = True

                    .BtnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
                    .BtnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnDestination.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnManageCurrency.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnTO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnManageMargin.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .GridColumn7.Visible = True
                    .GridColumn7.OptionsColumn.AllowShowHide = True
                    .GridColumn8.Visible = True
                    .GridColumn8.OptionsColumn.AllowShowHide = True
                    .GridColumn12.Visible = True
                    .GridColumn12.OptionsColumn.AllowShowHide = True
                End With
                With FrmEdit
                    .windowsUIButtonPanelMain.Buttons(2).Properties.Enabled = True
                    .windowsUIButtonPanelMain.Buttons(3).Properties.Enabled = True
                    .LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    .LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    .LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                End With
            Case "DMC"
                With FrmMain
                    .RibbonPageGroup1.Visible = False
                    .BtnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnJunk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BrnCanceled.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BtnMatching.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .RibbonPageGroup5.Visible = True
                    .BcPendingDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcPendingDmc.Checked = True
                    .BcFixedDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcFixedDmc.Checked = True
                    .BcPendingTo.Checked = False
                    .BcPendingTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcFixedTo.Checked = False
                    .BcFixedTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                    .BtnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
                    .BtnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnDestination.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnManageCurrency.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnTO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnManageMargin.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .GridColumn7.Visible = True
                    .GridColumn7.OptionsColumn.AllowShowHide = True
                    .GridColumn8.Visible = True
                    .GridColumn8.OptionsColumn.AllowShowHide = True
                    .GridColumn12.Visible = True
                    .GridColumn12.OptionsColumn.AllowShowHide = True
                End With
                With FrmEdit
                    .windowsUIButtonPanelMain.Buttons(2).Properties.Enabled = False
                    .windowsUIButtonPanelMain.Buttons(3).Properties.Enabled = False
                    .LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    .LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    .LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                End With
            Case "TO"
                With FrmMain
                    .RibbonPageGroup1.Visible = False
                    .BtnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnJunk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BrnCanceled.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnMatching.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .RibbonPageGroup5.Visible = False

                    .BcPendingDmc.Checked = False
                    .BcPendingDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BcFixedDmc.Checked = False
                    .BcFixedDmc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                    .BcPendingTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcPendingTo.Checked = True
                    .BcFixedTo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    .BcFixedTo.Checked = True


                    .BtnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
                    .BtnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnDestination.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnManageCurrency.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnTO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .BtnManageMargin.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .GridColumn7.Visible = False
                    .GridColumn7.OptionsColumn.AllowShowHide = False
                    .GridColumn8.Visible = False
                    .GridColumn8.OptionsColumn.AllowShowHide = False
                    .GridColumn12.Visible = False
                    .GridColumn12.OptionsColumn.AllowShowHide = False
                End With
                With FrmEdit
                    .windowsUIButtonPanelMain.Buttons(2).Properties.Enabled = False
                    .windowsUIButtonPanelMain.Buttons(3).Properties.Enabled = False
                    .LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    .LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    .LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                End With
        End Select
    End Sub

End Class
