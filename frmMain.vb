Imports System.ComponentModel
Imports System.Text
Imports DevExpress.LookAndFeel


Partial Public Class frmMain

    Public Sub Wait(ByVal wait As Boolean)
        If wait = True Then
            Try
                Me.SplashScreenManager1.ShowWaitForm()
            Catch ex As Exception

            End Try
        Else
            Try
                Me.SplashScreenManager1.CloseWaitForm()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnRate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRate.ItemClick
        Wait(True)
        Dim dt As New DataTable()
        dt = ParseText()
        GridControl1.DataSource = dt
        GridView1.BestFitColumns()
        Wait(False)
    End Sub

    Private Function ParseText() As DataTable
        Dim result As New DataTable()
        Dim sourceText As String = ""
        Try
            sourceText = My.Computer.Clipboard.GetText()
        Catch ex As Exception

        End Try
        sourceText = sourceText.Replace(vbTab, "$;&")
        Dim txtBox As New TextBox
        txtBox.Text = sourceText

        Dim lineArray() As String

        result.Columns.Add("BookingID")
        result.Columns.Add("Reference")
        result.Columns.Add("HotelCode")
        result.Columns.Add("HotelName")
        result.Columns.Add("HotelCountry")
        result.Columns.Add("GwgStatus")
        result.Columns.Add("PurchaseCurrency")
        result.Columns.Add("PurchasePrice")
        result.Columns.Add("SalesCurrency")
        result.Columns.Add("SalesPrice")
        result.Columns.Add("GwgHandlingFee")
        result.Columns.Add("Margin")
        result.Columns.Add("Difference")
        result.Columns.Add("CurrencyHotelTC")
        result.Columns.Add("NetRateHotelTC")
        result.Columns.Add("NetRateHandlingTC")
        result.Columns.Add("CheckHotel")
        result.Columns.Add("CompanyGroup")
        result.Columns.Add("BookingDate")
        result.Columns.Add("TravelDate")
        result.Columns.Add("RoomType")
        result.Columns.Add("Board")
        result.Columns.Add("Duration")
        result.Columns.Add("TransferTo")
        result.Columns.Add("TransferFrom")
        result.Columns.Add("Pax")
        result.Columns.Add("Adult")
        result.Columns.Add("Child")
        result.Columns.Add("ImportDate")
        result.Columns.Add("IncomingAgency")
        result.Columns.Add("BookingStateDesc")
        result.Columns.Add("HotelFlag")
        result.Columns.Add("MissingBookings")
        result.Columns.Add("MarginCheck")
        result.Columns.Add("DifferenceTOPrice")
        result.Columns.Add("ActionBy")
        result.Columns.Add("Status")
        result.Columns.Add("Comments")
        result.Columns.Add("DifferenceReason")
        result.Columns.Add("PriceBreakdown")
        result.Columns.Add("LoginIID")

        Dim lineText As String

        For x = 0 To txtBox.Lines.Count - 1
            lineText = "0$;&" & txtBox.Lines(x)
            lineArray = Split(lineText, "$;&")
            result.Rows.Add(lineArray)
        Next

        Return result
    End Function

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Wait(True)
        Dim query As String = ""
        Dim noNewRecords As Boolean = True
        'query = "INSERT INTO Bookings (Reference, Hotelcode, Hotelname, HotelCountry, GWG_Status, PurchaseCurrency, PurchasePrice, SalesCurrency, SalesPrice, GWGHandlingFee, Margin, Difference, CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC, CheckHotel, Company_Group, Bookingdate, Traveldate, Roomtype, Board, Duration, TransferTo, TransferFrom, Pax, Adult, Child, ImportDate, IncomingAgency, BookingStateDesc, HotelFlag, MissingBookings, MarginCheck, DifferenceTOPrice, ActionBy, Status, Comments, DifferenceReason, PriceBreakdown) VALUES"
        Dim lineText As String = ""

        Dim reference As String
        Dim hotelCode As String
        Dim hotelName As String
        Dim hotelCountry As String
        Dim gwgStatus As String
        Dim purchaseCurrency As String
        Dim purchasePrice As String
        Dim salesCurrency As String
        Dim salesPrice As String
        Dim gwgHandlingFee As String
        Dim margin As String
        Dim difference As String
        Dim currencyHotelTC As String
        Dim netRateHotelTC As String
        Dim netRateHandlingTC As String
        Dim checkHotel As String
        Dim companyGroup As String
        Dim bookingDate As String
        Dim traveldate As String
        Dim roomType As String
        Dim board As String
        Dim duration As String
        Dim transferTo As String
        Dim transferFrom As String
        Dim pax As String
        Dim adult As String
        Dim child As String
        Dim importDate As String
        Dim incomingAgency As String
        Dim bookingStateDesc As String
        Dim hotelFlag As String
        Dim missingBookings As String
        Dim marginCheck As String
        Dim differenceTOPrice As String
        Dim actionBy As String
        Dim status As String
        Dim comments As String
        Dim differenceReason As String
        Dim priceBreakdown As String
        Dim loginId As Integer = GV.CurrentUser.LoginId

        For x = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(x, "BookingID").ToString = "0" Then

                With GridView1
                    reference = .GetRowCellValue(x, "Reference").ToString
                    hotelCode = .GetRowCellValue(x, "HotelCode").ToString
                    hotelName = Replace(.GetRowCellValue(x, "HotelName").ToString, "'", "''")
                    hotelCountry = .GetRowCellValue(x, "HotelCountry").ToString
                    gwgStatus = .GetRowCellValue(x, "GwgStatus").ToString
                    purchaseCurrency = .GetRowCellValue(x, "PurchaseCurrency").ToString
                    purchasePrice = Val(.GetRowCellValue(x, "PurchasePrice").ToString).ToString
                    salesCurrency = .GetRowCellValue(x, "SalesCurrency").ToString
                    salesPrice = Val(.GetRowCellValue(x, "SalesPrice").ToString).ToString
                    gwgHandlingFee = Val(.GetRowCellValue(x, "GwgHandlingFee").ToString).ToString
                    margin = Val(.GetRowCellValue(x, "Margin").ToString).ToString
                    difference = Val(.GetRowCellValue(x, "Difference").ToString).ToString
                    currencyHotelTC = .GetRowCellValue(x, "CurrencyHotelTC").ToString
                    netRateHotelTC = Val(.GetRowCellValue(x, "NetRateHotelTC").ToString).ToString
                    netRateHandlingTC = Val(.GetRowCellValue(x, "NetRateHandlingTC").ToString).ToString
                    checkHotel = .GetRowCellValue(x, "CheckHotel").ToString
                    companyGroup = .GetRowCellValue(x, "CompanyGroup").ToString
                    bookingDate = TextToDate(.GetRowCellValue(x, "BookingDate").ToString).ToString("MM/dd/yyyy")
                    traveldate = TextToDate(.GetRowCellValue(x, "TravelDate").ToString).ToString("MM/dd/yyyy")
                    roomType = .GetRowCellValue(x, "RoomType").ToString
                    board = .GetRowCellValue(x, "Board").ToString
                    duration = .GetRowCellValue(x, "Duration").ToString
                    transferTo = .GetRowCellValue(x, "TransferTo").ToString
                    transferFrom = .GetRowCellValue(x, "TransferFrom").ToString
                    pax = .GetRowCellValue(x, "Pax").ToString
                    adult = .GetRowCellValue(x, "Adult").ToString
                    child = .GetRowCellValue(x, "Child").ToString
                    importDate = TextToDate(.GetRowCellValue(x, "ImportDate").ToString).ToString("MM/dd/yyyy")
                    incomingAgency = .GetRowCellValue(x, "IncomingAgency").ToString
                    bookingStateDesc = .GetRowCellValue(x, "BookingStateDesc").ToString
                    hotelFlag = .GetRowCellValue(x, "HotelFlag").ToString
                    missingBookings = .GetRowCellValue(x, "MissingBookings").ToString
                    marginCheck = .GetRowCellValue(x, "MarginCheck").ToString
                    differenceTOPrice = .GetRowCellValue(x, "DifferenceTOPrice").ToString
                    actionBy = .GetRowCellValue(x, "ActionBy").ToString
                    status = .GetRowCellValue(x, "Status").ToString
                    comments = Replace(.GetRowCellValue(x, "Comments").ToString, "'", "''")
                    differenceReason = Replace(.GetRowCellValue(x, "DifferenceReason").ToString, "'", "''")
                    priceBreakdown = .GetRowCellValue(x, "PriceBreakdown").ToString

                End With


                lineText = String.Format("EXEC dbo.SaveBooking 0, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}', {39}; ", _
                                         reference, hotelCode, hotelName, hotelCountry, gwgStatus, purchaseCurrency, purchasePrice, salesCurrency, salesPrice, gwgHandlingFee, margin, difference, currencyHotelTC, netRateHotelTC, netRateHandlingTC, checkHotel, companyGroup, bookingDate, traveldate, roomType, board, duration, transferTo, transferFrom, pax, adult, child, importDate, incomingAgency, bookingStateDesc, hotelFlag, missingBookings, marginCheck, differenceTOPrice, actionBy, status, comments, differenceReason, priceBreakdown, loginId)
                If hotelCode <> "" Then
                    query &= lineText
                End If

                noNewRecords = False
            End If

        Next


        If Not noNewRecords Then
            Dim result As String = ExClass.QuerySet(query)

            If Not result = "True" Then
                Wait(False)
                MsgBox(result)
            End If
        End If
        Wait(False)
    End Sub

    Public Sub UpdateCertainRow(ByVal rowHandle As Integer, ByVal booking As Booking)

        With GridView1
            .SetRowCellValue(rowHandle, "Reference", booking.Reference)
            .SetRowCellValue(rowHandle, "HotelCode", booking.HotelCode)
            .SetRowCellValue(rowHandle, "HotelName", booking.HotelName)
            .SetRowCellValue(rowHandle, "HotelCountry", booking.CountryCode)
            .SetRowCellValue(rowHandle, "GwgStatus", booking.GwgStatus)
            .SetRowCellValue(rowHandle, "PurchaseCurrency", booking.PurchaseCurrency)
            .SetRowCellValue(rowHandle, "PurchasePrice", booking.PurchasePrice)
            .SetRowCellValue(rowHandle, "SalesCurrency", booking.SalesCurrency)
            .SetRowCellValue(rowHandle, "SalesPrice", booking.SalesPrice)
            .SetRowCellValue(rowHandle, "GwgHandlingFee", booking.GwgHandlingFee)
            .SetRowCellValue(rowHandle, "Margin", booking.Margin)
            .SetRowCellValue(rowHandle, "Difference", booking.Difference)
            .SetRowCellValue(rowHandle, "CurrencyHotelTC", booking.CurrencyHotelTC)
            .SetRowCellValue(rowHandle, "NetRateHotelTC", booking.NetRateHotelTC)
            .SetRowCellValue(rowHandle, "NetRateHandlingTC", booking.NetRateHandlingTC)
            .SetRowCellValue(rowHandle, "CheckHotel", booking.CheckHotel)
            .SetRowCellValue(rowHandle, "CompanyGroup", booking.CompanyGroup)
            .SetRowCellValue(rowHandle, "BookingDate", booking.BookingDate)
            .SetRowCellValue(rowHandle, "TravelDate", booking.TravelDate)
            .SetRowCellValue(rowHandle, "RoomType", booking.RoomType)
            .SetRowCellValue(rowHandle, "Board", booking.Board)
            .SetRowCellValue(rowHandle, "Duration", booking.Duration)
            .SetRowCellValue(rowHandle, "TransferTo", booking.TransferTo)
            .SetRowCellValue(rowHandle, "TransferFrom", booking.TransferFrom)
            .SetRowCellValue(rowHandle, "Pax", booking.Pax)
            .SetRowCellValue(rowHandle, "Adult", booking.Adult)
            .SetRowCellValue(rowHandle, "Child", booking.Child)
            .SetRowCellValue(rowHandle, "ImportDate", booking.ImportDate)
            .SetRowCellValue(rowHandle, "IncomingAgency", booking.IncomingAgency)
            .SetRowCellValue(rowHandle, "BookingStateDesc", booking.BookingStateDesc)
            .SetRowCellValue(rowHandle, "HotelFlag", booking.HotelFlag)
            .SetRowCellValue(rowHandle, "MissingBookings", booking.MissingBookings)
            .SetRowCellValue(rowHandle, "MarginCheck", booking.MarginCheck)
            .SetRowCellValue(rowHandle, "DifferenceTOPrice", booking.DifferenceToPrice)
            .SetRowCellValue(rowHandle, "ActionBy", booking.ActionBy)
            .SetRowCellValue(rowHandle, "Status", booking.Status)
            .SetRowCellValue(rowHandle, "Comments", booking.Comments)
            .SetRowCellValue(rowHandle, "DifferenceReason", booking.DifferenceReason)
            .SetRowCellValue(rowHandle, "PriceBreakdown", booking.PriceBreakdown)

        End With
    End Sub

    Private Function TextToDate(ByVal dateText As String) As Date
        Dim result As Date = New Date(1900, 1, 1)
        Dim tempDate() As String
        tempDate = Split(dateText, ".")
        If dateText <> "" Then
            Try
                result = New Date(CInt(tempDate(2).Substring(0, 4)), CInt(tempDate(1)), CInt(tempDate(0)))
            Catch ex As Exception

            End Try

        End If

        Return result
    End Function

    Private Sub btnLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoad.ItemClick
        Wait(True)
        Dim query As String = "SELECT * FROM Booking;"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        GridControl1.DataSource = dt
        Wait(False)
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim bookingId As Long
        bookingId = CInt(GridView1.GetFocusedRowCellValue("BookingID"))
        If bookingId > 0 Then
            frmEdit.bookingId = bookingId
            frmEdit.Show()
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Theme = UserLookAndFeel.Default.SkinName.ToString
        My.Settings.Save()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.Close()
        If Not My.Settings.Theme = "" Then
            UserLookAndFeel.Default.SkinName = My.Settings.Theme.ToString()
        End If
    End Sub

    Private Sub btnSwitchUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSwitchUser.ItemClick
        frmLogin.ShowDialog()
    End Sub

    Private Sub btnAddNewUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewUser.ItemClick
        frmSignup.ShowDialog()
    End Sub

    Public Sub Authorize()
        If GV.CurrentUser.Authority = "ADMIN" Or GV.CurrentUser.Authority = "DEVELOPER" Then
            btnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            btnAddNewUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            btnManageUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnAddNewUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Private Sub btnChangePassword_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangePassword.ItemClick
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub btnExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExit.ItemClick
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnManageUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnManageUsers.ItemClick
        frmManageUsers.ShowDialog()
    End Sub
End Class
