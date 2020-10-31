Imports DevExpress.LookAndFeel


Partial Public Class FrmMain
    Dim bookingDT As New DataTable()
    ReadOnly defaultGridLayout As System.IO.Stream = New System.IO.MemoryStream()
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

    Public Sub FillRibbonDestinations()
        Dim dt As New DataTable()
        If GV.CurrentUser.Authority = "DEVELOPER" Then
            Dim query As String = "SELECT * FROM Destination ORDER BY Destination;"
            dt = ExClass.QueryGet(query)
        Else
            dt.Columns.Add("DestinationID")
            dt.Columns.Add("DestinationCode")
            dt.Columns.Add("Destination")
            Dim destination As New Destination()
            With GV.CurrentUser
                For x = 0 To .UserDestinations.Count - 1
                    destination = New Destination()
                    destination = .UserDestinations(x)
                    dt.Rows.Add({destination.DestinationId, destination.DestinationCode, destination.Destination})
                Next
            End With
        End If

        RepositoryItemLookUpEdit1.DataSource = Nothing
        RepositoryItemLookUpEdit1.DataSource = dt
        RepositoryItemLookUpEdit1.ValueMember = "DestinationCode"
        RepositoryItemLookUpEdit1.DisplayMember = "Destination"

    End Sub
    Private Sub BtnRate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRate.ItemClick
        Wait(True)

        ResetGridLayout()

        Dim dt As DataTable = ParseText()
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
        Dim txtBox As New TextBox With {
            .Text = sourceText
        }

        Dim lineArray() As String

        result.Columns.Add("BookingID")
        result.Columns.Add("Reference")
        result.Columns.Add("HotelCode")
        result.Columns.Add("HotelName")
        result.Columns.Add("HotelCountry")
        result.Columns.Add("GwgStatus")
        result.Columns.Add("BookingStatus")
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
        result.Columns.Add("MPImportDate")
        result.Columns.Add("IncomingAgency")
        result.Columns.Add("BookingStateDesc")
        result.Columns.Add("HotelFlag")
        result.Columns.Add("MissingBookings")
        result.Columns.Add("MarginCheck")
        result.Columns.Add("DifferenceTOPrice")
        result.Columns.Add("ActionBy")
        result.Columns.Add("Status")
        result.Columns.Add("Comments")
        result.Columns.Add("AdjustedPrice")
        result.Columns.Add("PriceBreakdown")
        result.Columns.Add("LoginIID")

        Dim lineText As String
        Dim formatError As Boolean = False
        Dim errorMessage As String = ""
        For x = 0 To txtBox.Lines.Count - 1
            Try
                lineText = "0$;&" & txtBox.Lines(x)
                lineArray = Split(lineText, "$;&")
                result.Rows.Add(lineArray)
            Catch ex As Exception
                errorMessage = ex.ToString
                formatError = True
                Exit For
            End Try

        Next
        If formatError Then
            result = Nothing
            Wait(False)
            MsgBox(errorMessage)
        End If
        Return result
    End Function

    Private Sub BtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSave.ItemClick
        Wait(True)
        Dim query As String = ""
        Dim noNewRecords As Boolean = True
        Dim lineText As String

        Dim reference As String
        Dim hotelCode As String
        Dim hotelName As String
        Dim hotelCountry As String
        Dim gwgStatus As String
        Dim bookingStatus As String
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
        Dim mpImportDate As String
        Dim incomingAgency As String
        Dim bookingStateDesc As String
        Dim hotelFlag As String
        Dim missingBookings As String
        Dim marginCheck As String
        Dim differenceTOPrice As String
        Dim actionBy As String
        Dim priceBreakdown As String
        Dim loginId As Integer = GV.CurrentUser.LoginId
        Dim junk As Boolean

        For x = 0 To GridView1.RowCount - 1

            If GridView1.GetRowCellValue(x, "BookingID").ToString = "0" Then

                With GridView1
                    reference = .GetRowCellValue(x, "Reference").ToString
                    hotelCode = .GetRowCellValue(x, "HotelCode").ToString
                    hotelName = Replace(.GetRowCellValue(x, "HotelName").ToString, "'", "''")
                    hotelCountry = .GetRowCellValue(x, "HotelCountry").ToString
                    gwgStatus = .GetRowCellValue(x, "GwgStatus").ToString
                    bookingStatus = .GetRowCellValue(x, "BookingStatus").ToString
                    purchaseCurrency = .GetRowCellValue(x, "PurchaseCurrency").ToString
                    purchasePrice = Val(.GetRowCellValue(x, "PurchasePrice").ToString.Replace(",", "")).ToString
                    salesCurrency = .GetRowCellValue(x, "SalesCurrency").ToString
                    salesPrice = Val(.GetRowCellValue(x, "SalesPrice").ToString.Replace(",", "")).ToString
                    gwgHandlingFee = Val(.GetRowCellValue(x, "GwgHandlingFee").ToString.Replace(",", "")).ToString
                    margin = Val(.GetRowCellValue(x, "Margin").ToString.Replace(",", "")).ToString
                    difference = Val(.GetRowCellValue(x, "Difference").ToString.Replace(",", "")).ToString
                    currencyHotelTC = .GetRowCellValue(x, "CurrencyHotelTC").ToString
                    netRateHotelTC = Val(.GetRowCellValue(x, "NetRateHotelTC").ToString.Replace(",", "")).ToString
                    netRateHandlingTC = Val(.GetRowCellValue(x, "NetRateHandlingTC").ToString.Replace(",", "")).ToString
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
                    mpImportDate = TextToDate(.GetRowCellValue(x, "MPImportDate").ToString).ToString("MM/dd/yyyy")
                    incomingAgency = .GetRowCellValue(x, "IncomingAgency").ToString
                    bookingStateDesc = .GetRowCellValue(x, "BookingStateDesc").ToString
                    hotelFlag = .GetRowCellValue(x, "HotelFlag").ToString
                    missingBookings = .GetRowCellValue(x, "MissingBookings").ToString
                    marginCheck = .GetRowCellValue(x, "MarginCheck").ToString
                    differenceTOPrice = .GetRowCellValue(x, "DifferenceTOPrice").ToString
                    actionBy = .GetRowCellValue(x, "ActionBy").ToString
                    priceBreakdown = .GetRowCellValue(x, "PriceBreakdown").ToString

                End With
                If hotelCode <> "" Then

                    If purchaseCurrency = "" Then
                        purchaseCurrency = currencyHotelTC
                    End If

                    If salesCurrency = "" Then
                        salesCurrency = purchaseCurrency
                    End If


                    junk = CBool(Booking.CheckJunk(gwgStatus, marginCheck, Val(netRateHotelTC), hotelName))
                    lineText = String.Format("EXEC dbo.SaveBooking 0, '{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', '{6}',
                                            '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', 
                                            '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}',
                                            '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}',
                                            '{34}', '{35}', {36}, {37}, '{38}', '{39}'; ",
                                                reference, hotelCode, hotelName, hotelCountry, gwgStatus,
                                                purchaseCurrency, purchasePrice, salesCurrency, salesPrice,
                                                gwgHandlingFee, margin, difference, currencyHotelTC, netRateHotelTC,
                                                netRateHandlingTC, checkHotel, companyGroup, bookingDate, traveldate,
                                                roomType, board, duration, transferTo, transferFrom, pax, adult, child,
                                                importDate, incomingAgency, bookingStateDesc, hotelFlag, missingBookings,
                                                marginCheck, differenceTOPrice, actionBy, priceBreakdown, loginId,
                                                junk.ToString, bookingStatus, mpImportDate)

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

        For x = 0 To BookingDT.Columns.Count - 1
            BookingDT.Columns(x).ReadOnly = False
        Next


        With BookingDT
            .Rows(rowHandle).SetField("Reference", booking.Reference)
            .Rows(rowHandle).SetField("HotelCode", booking.HotelCode)
            .Rows(rowHandle).SetField("HotelName", booking.HotelName)
            .Rows(rowHandle).SetField("HotelCountry", booking.CountryCode)
            .Rows(rowHandle).SetField("GwgStatus", booking.GwgStatus)
            .Rows(rowHandle).SetField("BookingStatus", booking.BookingStatus)
            .Rows(rowHandle).SetField("PurchaseCurrency", booking.PurchaseCurrency)
            .Rows(rowHandle).SetField("PurchasePrice", booking.PurchasePrice)
            .Rows(rowHandle).SetField("SalesCurrency", booking.SalesCurrency)
            .Rows(rowHandle).SetField("SalesPrice", booking.SalesPrice)
            .Rows(rowHandle).SetField("GwgHandlingFee", booking.GwgHandlingFee)
            .Rows(rowHandle).SetField("Margin", booking.Margin)
            .Rows(rowHandle).SetField("Difference", booking.Difference)
            .Rows(rowHandle).SetField("CurrencyHotelTC", booking.CurrencyHotelTC)
            .Rows(rowHandle).SetField("NetRateHotelTC", booking.NetRateHotelTC)
            .Rows(rowHandle).SetField("NetRateHandlingTC", booking.NetRateHandlingTC)
            .Rows(rowHandle).SetField("CheckHotel", booking.CheckHotel)
            .Rows(rowHandle).SetField("CompanyGroup", booking.CompanyGroup)
            .Rows(rowHandle).SetField("BookingDate", booking.BookingDate)
            .Rows(rowHandle).SetField("TravelDate", booking.TravelDate)
            .Rows(rowHandle).SetField("RoomType", booking.RoomType)
            .Rows(rowHandle).SetField("Board", booking.Board)
            .Rows(rowHandle).SetField("Duration", booking.Duration)
            .Rows(rowHandle).SetField("TransferTo", booking.TransferTo)
            .Rows(rowHandle).SetField("TransferFrom", booking.TransferFrom)
            .Rows(rowHandle).SetField("Pax", booking.Pax)
            .Rows(rowHandle).SetField("Adult", booking.Adult)
            .Rows(rowHandle).SetField("Child", booking.Child)
            .Rows(rowHandle).SetField("ImportDate", booking.ImportDate)
            .Rows(rowHandle).SetField("MPImportDate", booking.MPImportDate)
            .Rows(rowHandle).SetField("IncomingAgency", booking.IncomingAgency)
            .Rows(rowHandle).SetField("BookingStateDesc", booking.BookingStateDesc)
            .Rows(rowHandle).SetField("HotelFlag", booking.HotelFlag)
            .Rows(rowHandle).SetField("MissingBookings", booking.MissingBookings)
            .Rows(rowHandle).SetField("MarginCheck", booking.MarginCheck)
            .Rows(rowHandle).SetField("DifferenceTOPrice", booking.DifferenceToPrice)
            .Rows(rowHandle).SetField("ActionBy", booking.LastUser.Username)
            .Rows(rowHandle).SetField("Status", booking.Status)
            .Rows(rowHandle).SetField("Comments", booking.Comments)
            .Rows(rowHandle).SetField("AdjustedPrice", booking.AdjustedPrice)
            .Rows(rowHandle).SetField("PriceBreakdown", booking.PriceBreakdown)
        End With


    End Sub

    Public Sub UpdateCertainRow(ByVal adjustPrice As Boolean, ByVal booking As Booking)

        For x = 0 To BookingDT.Columns.Count - 1
            BookingDT.Columns(x).ReadOnly = False
        Next

        For x = 0 To GridView1.RowCount - 1
            If GridView1.IsRowSelected(x) And FrmEdit.BookingsList.Contains(CInt(GridView1.GetRowCellValue(x, "BookingID"))) Then
                With BookingDT
                    .Rows(x).SetField("ActionBy", booking.LastUser.Username)
                    .Rows(x).SetField("Status", booking.Status)
                    .Rows(x).SetField("Comments", booking.Comments)
                    If adjustPrice Then
                        .Rows(x).SetField("AdjustedPrice", booking.AdjustedPrice)
                    End If
                End With
            End If
        Next

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

    Private Sub LoadData(ByVal status As String, ByVal allCountries As Boolean)

        If BeCountry.EditValue Is Nothing And Not allCountries Then
            MsgBox("Please select destination!")
            Exit Sub
        ElseIf GV.CurrentUser.UserOperators = "" And Not allCountries Then
            MsgBox("You don't have permission to view data!")
            Exit Sub
        End If

        Wait(True)


        Dim startDate, endDate As Date
        Dim destination As String
        startDate = CDate(BeDateFrom.EditValue)
        endDate = CDate(BeDateTo.EditValue)
        destination = CStr(BeCountry.EditValue)


        Dim querySelect As String = "SELECT BookingID, Reference, HotelCode, HotelName, HotelCountry, GwgStatus, PurchaseCurrency, PurchasePrice,
                                    SalesCurrency, SalesPrice, GwgHandlingFee, Margin, Difference, CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC,
                                    CheckHotel, CompanyGroup, BookingDate, TravelDate, RoomType, Board, Duration, TransferTo, TransferFrom,
                                    Pax, Adult, Child, ImportDate, IncomingAgency, BookingStateDesc, HotelFlag, MissingBookings, MarginCheck,
                                    DifferenceTOPrice, [Login].Username AS ActionBy, [Status], Comments,
                                    AdjustedPrice, PriceBreakdown, Booking.LoginID, Junk, BookingStatus, MPImportDate
                                    FROM Booking 
                                    JOIN [Login] ON [Login].LoginID = Booking.ActionBy"


        Dim query As String
        If Not allCountries Then
            query = String.Format("{0}
                              WHERE HotelCountry = '{1}' AND (TravelDate BETWEEN '{2}' AND '{3}') AND CompanyGroup IN {4} {5};" _
                              , querySelect, destination,
                              startDate.ToString("MM/dd/yyyy"), endDate.ToString("MM/dd/yyyy"),
                              GV.CurrentUser.UserOperators, status)
        Else
            query = String.Format("{0}
                              WHERE (TravelDate BETWEEN '{1}' AND '{2}' {3});" _
                              , querySelect,
                              startDate.ToString("MM/dd/yyyy"), endDate.ToString("MM/dd/yyyy"), status)

        End If

        BookingDT = ExClass.QueryGet(query)
        GridControl1.DataSource = BookingDT

        Wait(False)

    End Sub

    Private Sub BtnLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLoad.ItemClick
        LoadData("", False)
    End Sub

    Private Sub RemoveRows()
        GridView1.DeleteSelectedRows()
    End Sub

    Private Sub ViewBookingDetails()

        If GridView1.SelectedRowsCount = 1 Then
            FrmEdit.BookingsList.Clear()
            Dim bookingId As Long
            bookingId = CInt(GridView1.GetFocusedRowCellValue("BookingID"))

            If bookingId > 0 Then
                ' Check if the booking is read-only
                GetReadOnlyBookings(True, bookingId.ToString)
                LockBookings(bookingId.ToString, True)
                FrmEdit.BookingId = bookingId
                FrmEdit.ShowDialog()
                LockBookings(bookingId.ToString, False)
            End If
        ElseIf GridView1.SelectedRowsCount > 1 Then
            Dim bookingsList As New List(Of Integer)

            For Each i As Integer In GridView1.GetSelectedRows
                bookingsList.Add(CInt(GridView1.GetRowCellValue(i, "BookingID")))
            Next

            ' Check if some bookings are locked.
            Dim bookings As String = String.Join(",", bookingsList.[Select](Function(i) i.ToString()).ToArray())
            GetReadOnlyBookings(False, bookings)
            LockBookings(bookings, True)
            FrmEdit.BookingsList = bookingsList
            FrmEdit.ShowDialog()
            LockBookings(bookings, False)
        End If

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        ViewBookingDetails()
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        LockBookings("", False)
        My.Settings.Theme = UserLookAndFeel.Default.SkinName.ToString
        My.Settings.Save()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BeDateFrom.EditValue = My.Settings.RibbonDateFrom
        BeDateTo.EditValue = Today().AddYears(3)

        If My.Settings.Destination <> "" Then
            Try
                For x = 0 To GV.CurrentUser.UserDestinations.Count - 1
                    If GV.CurrentUser.UserDestinations(x).DestinationCode = My.Settings.Destination Then
                        BeCountry.EditValue = My.Settings.Destination
                        Exit For
                    End If
                Next

            Catch ex As Exception

            End Try
        End If

        FrmLogin.Close()
        If Not My.Settings.Theme = "" Then
            UserLookAndFeel.Default.SkinName = My.Settings.Theme.ToString()
        End If
    End Sub

    Private Sub BtnSwitchUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSwitchUser.ItemClick
        FrmLogin.ShowDialog()
        bookingDT.Reset()
    End Sub

    Private Sub BtnChangePassword_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnChangePassword.ItemClick
        FrmChangePassword.ShowDialog()
    End Sub

    Private Sub BtnExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExit.ItemClick
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub BtnManageUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnManageUsers.ItemClick
        FrmManageUsers.ShowDialog()
    End Sub

    Private Sub BeDateFrom_EditValueChanged(sender As Object, e As EventArgs) Handles BeDateFrom.EditValueChanged
        My.Settings.RibbonDateFrom = CDate(BeDateFrom.EditValue)
        My.Settings.Save()
    End Sub

    Private Sub BtnManageDestination_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDestination.ItemClick
        FrmManageDestinations.ShowDialog()
    End Sub

    Private Sub BtnManageMargin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnManageMargin.ItemClick
        FrmManageMargin.ShowDialog()
    End Sub

    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ViewBookingDetails()
        ElseIf e.KeyCode = Keys.Delete Then
            RemoveRows()
        End If
    End Sub

    Private Sub BeCountry_EditValueChanged(sender As Object, e As EventArgs) Handles BeCountry.EditValueChanged
        My.Settings.Destination = CStr(BeCountry.EditValue)
        My.Settings.Save()
    End Sub

    Private Sub BtnJunk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnJunk.ItemClick
        LoadData("AND Junk = 1 AND GwgStatus != 'Can'", False)
    End Sub

    Private Sub BrnCanceled_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BrnCanceled.ItemClick
        LoadData("AND GwgStatus = 'Can'", False)
    End Sub

    Private Sub BtnMatching_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMatching.ItemClick
        Dim status As String
        status = " AND Junk = 0 AND GwgStatus != 'Can' AND NegativeMargin = 0 
                    AND ExcessiveMargin = 0 AND MismatchCalc = 0"
        LoadData(status, False)
    End Sub

    Private Sub BtnShowDefict_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnShowDefict.ItemClick
        Dim status As String = " AND Junk = 0 AND GwgStatus != 'Can' AND ([Status] IS NULL OR [Status] = '') AND ("

        If Not BcExcessive.Checked And Not BcNegative.Checked And Not BcMismatch.Checked Then
            MsgBox("Please select at least one option!")
            Exit Sub
        End If

        If BcNegative.Checked Then
            status &= "NegativeMargin = 1"
        End If
        If BcExcessive.Checked Then
            If BcNegative.Checked Then
                status &= " OR "
            End If
            status &= "ExcessiveMargin = 1"
        End If
        If BcMismatch.Checked Then
            If BcNegative.Checked Or BcExcessive.Checked Then
                status &= " OR "
            End If
            status &= "MismatchCalc = 1"
        End If
        status &= ");"
        LoadData(status, False)

    End Sub

    Private Sub BtnShow_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnShow.ItemClick
        Dim status As String = " AND Junk = 0 AND GwgStatus != 'Can' AND ("
        If Not BcPendingDmc.Checked And Not BcPendingTo.Checked And Not BcFixedDmc.Checked And Not BcFixedTo.Checked And Not BcNewRecord.Checked Then
            MsgBox("Please select at least one option!")
            Exit Sub
        End If

        If BcPendingDmc.Checked Then
            status &= "[Status] = 'PENDING DMC'"
        End If

        If BcFixedDmc.Checked Then
            If BcPendingDmc.Checked Then
                status &= " OR "
            End If
            status &= "[Status] = 'FIXED DMC'"
        End If
        If BcPendingTo.Checked Then
            If BcPendingDmc.Checked Or BcFixedDmc.Checked Then
                status &= " OR "
            End If
            status &= "[Status] = 'PENDING T/O'"
        End If
        If BcFixedTo.Checked Then
            If BcPendingDmc.Checked Or BcFixedDmc.Checked Or BcPendingTo.Checked Then
                status &= " OR "
            End If
            status &= "[Status] = 'FIXED T/O'"
        End If
        If BcNewRecord.Checked Then
            If BcPendingDmc.Checked Or BcFixedDmc.Checked Or BcPendingTo.Checked Or BcFixedTo.Checked Then
                status &= " OR "
            End If
            status &= "[Status] IS NULL"
        End If
        status &= ");"
        LoadData(status, False)
    End Sub

    Private Sub BtnAddDispute_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnAddDispute.ItemClick
        ViewBookingDetails()
    End Sub

    Private Sub BtnTO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnTO.ItemClick
        FrmManageTourOperator.ShowDialog()
    End Sub

    Private Sub BtnManageCurrency_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnManageCurrency.ItemClick
        FrmCurrency.ShowDialog()
    End Sub

    Private Sub BtnErrors_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnErrors.ItemClick
        Dim status As String
        status = " AND (MissingCurrency = 1 OR MissingDestination = 1 OR MissingTO = 1 OR MissingMargin = 1)"
        LoadData(status, True)
    End Sub

    Private Sub BtnAbout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnAbout.ItemClick
        FrmAbout.ShowDialog()
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        If GridView1.FocusedColumn.Caption = "PriceBreakdown" Then
            Dim link As String
            link = CStr(GridView1.GetFocusedRowCellValue("PriceBreakdown"))
            If link <> "" Then
                Process.Start(link)
            End If
        End If
    End Sub

    Private Sub BhUsername_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bhUsername.ItemDoubleClick
        If GV.CurrentUser.Authority = "Admin" Or GV.CurrentUser.Authority = "Developer" Then
            FrmSQL.Show()
        End If
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GridView1.SaveLayoutToStream(defaultGridLayout)
        defaultGridLayout.Seek(0, System.IO.SeekOrigin.Begin)
    End Sub

    Private Sub ResetGridLayout()
        GridView1.RestoreLayoutFromStream(defaultGridLayout)
        defaultGridLayout.Seek(0, System.IO.SeekOrigin.Begin)
    End Sub

    Private Sub GetReadOnlyBookings(ByVal singleBooking As Boolean, ByVal bookingIDs As String)
        ' Check if the booking(s) is/are locked.
        If singleBooking Then
            Dim dt As DataTable = IsLocked(bookingIDs)
            If dt.Rows.Count > 0 Then
                Dim message As String = String.Format("The booking will open as Read-Only as it's locked by user '{0}' since '{1}'.",
                                                      dt.Rows(0)(1), CDate(dt.Rows(0)(2)).ToString("HH:mm"))
                MsgBox(message)
                FrmEdit.NoSave = True
            Else
                FrmEdit.NoSave = False
            End If
        Else
            Dim dt As DataTable = IsLocked(bookingIDs)

            If dt.Rows.Count > 0 Then
                Dim message As String

                Dim listOfReadOnlyBookings As String = ""
                For Each row As DataRow In dt.Rows
                    listOfReadOnlyBookings &= String.Format("Booking#: {0}, User: {1},  Since: {2}" & vbNewLine,
                                                                row(0), row(1), CDate(row(2)).ToString("HH:mm"))
                Next
                message = String.Format("Those bookings will open as Read-Only as they're locked by other users: " & vbNewLine & "{0}",
                                            listOfReadOnlyBookings)


                MsgBox(message)
                FrmEdit.NoSave = True
            Else
                FrmEdit.NoSave = False
            End If
        End If

    End Sub
    Private Function IsLocked(ByVal bookingIDs As String) As DataTable
        ' Return bookings locked by other users
        Dim result As DataTable
        Dim query As String = String.Format("
            SELECT Booking.Reference, [Login].FullName, Booking.LockTime
            FROM Booking
            JOIN [Login] ON Booking.Locked = [Login].LoginID
            WHERE Booking.Locked != {0} AND Booking.BookingID IN ({1});
        ", GV.CurrentUser.LoginId, bookingIDs)

        result = ExClass.QueryGet(query)

        Return result
    End Function

    Private Sub LockBookings(ByVal bookingIDs As String, ByVal setLocked As Boolean)
        Dim query As String
        If setLocked Then
            query = String.Format("
                        UPDATE Booking SET Locked = {0}, LockTime = GETDATE() WHERE BookingID IN ({1}) AND Locked IS NULL;
                    ", GV.CurrentUser.LoginId.ToString, bookingIDs)
        Else


            If bookingIDs <> "" Then
                query = String.Format("
                        UPDATE Booking SET Locked = NULL, LockTime = NULL WHERE BookingID IN ({0}) AND Locked = {1};
                    ", bookingIDs, GV.CurrentUser.LoginId.ToString)
            Else
                query = String.Format("
                        UPDATE Booking SET Locked = NULL, LockTime = NULL WHERE Locked = {0};
                    ", GV.CurrentUser.LoginId.ToString)
            End If
        End If

        ExClass.QuerySet(query)

    End Sub
End Class
