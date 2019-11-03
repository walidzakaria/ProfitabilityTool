Imports System.ComponentModel
Imports System.Text
Imports DevExpress.LookAndFeel


Partial Public Class frmMain
    Dim BookingDT As New DataTable()
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

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Wait(True)
        Dim query As String = ""
        Dim noNewRecords As Boolean = True
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

                    junk = Booking.CheckJunk(gwgStatus, marginCheck, Val(netRateHotelTC), hotelName)
                    lineText = String.Format("EXEC dbo.SaveBooking 0, '{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', {36}, {37}; ", _
                                             reference, hotelCode, hotelName, hotelCountry, gwgStatus, purchaseCurrency, purchasePrice, salesCurrency, salesPrice, gwgHandlingFee, margin, difference, currencyHotelTC, netRateHotelTC, netRateHandlingTC, checkHotel, companyGroup, bookingDate, traveldate, roomType, board, duration, transferTo, transferFrom, pax, adult, child, importDate, incomingAgency, bookingStateDesc, hotelFlag, missingBookings, marginCheck, differenceTOPrice, actionBy, priceBreakdown, loginId, junk.ToString)

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
            .Rows(rowHandle).SetField("IncomingAgency", booking.IncomingAgency)
            .Rows(rowHandle).SetField("BookingStateDesc", booking.BookingStateDesc)
            .Rows(rowHandle).SetField("HotelFlag", booking.HotelFlag)
            .Rows(rowHandle).SetField("MissingBookings", booking.MissingBookings)
            .Rows(rowHandle).SetField("MarginCheck", booking.MarginCheck)
            .Rows(rowHandle).SetField("DifferenceTOPrice", booking.DifferenceToPrice)
            .Rows(rowHandle).SetField("ActionBy", booking.ActionBy)
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
            If GridView1.IsRowSelected(x) Then
                With BookingDT
                    .Rows(x).SetField("ActionBy", booking.ActionBy)
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

    Private Sub LoadData(ByVal status As String)

        If beCountry.EditValue Is Nothing Then
            MsgBox("Please select destination!")
            Exit Sub
        ElseIf GV.CurrentUser.UserOperators = "" Then
            MsgBox("You don't have permission to view data!")
            Exit Sub
        End If

        Wait(True)




        Dim startDate, endDate As Date
        Dim destination As String
        startDate = beDateFrom.EditValue
        endDate = beDateTo.EditValue
        destination = beCountry.EditValue

        Dim querySelect As String = "SELECT BookingID, Reference, HotelCode, HotelName, HotelCountry, GwgStatus, PurchaseCurrency, PurchasePrice," _
                                    & " SalesCurrency, SalesPrice, GwgHandlingFee, Margin, Difference, CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC," _
                                    & " CheckHotel, CompanyGroup, BookingDate, TravelDate, RoomType, Board, Duration, TransferTo, TransferFrom," _
                                    & " Pax, Adult, Child, ImportDate, IncomingAgency, BookingStateDesc, HotelFlag, MissingBookings, MarginCheck," _
                                    & " DifferenceTOPrice, dbo.ActionBy(BookingID) AS ActionBy, dbo.LastStatus(BookingID) AS Status, dbo.LastComment(BookingID) AS Comments," _
                                    & " dbo.AdjustedPrice(BookingID) AS AdjustedPrice, PriceBreakdown, LoginID, Junk" _
                                    & " FROM Booking "


        Dim query As String = String.Format("{0}" _
                              & " WHERE HotelCountry = '{1}' AND (TravelDate BETWEEN '{2}' AND '{3}') AND CompanyGroup IN {4} {5};", querySelect, destination, _
                              startDate.ToString("MM/dd/yyyy"), endDate.ToString("MM/dd/yyyy"), GV.CurrentUser.UserOperators, status)


        BookingDT = ExClass.QueryGet(query)
        GridControl1.DataSource = BookingDT


        Wait(False)

    End Sub

    Private Sub btnLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoad.ItemClick
        LoadData("")
    End Sub

    Private Sub RemoveRows()
        GridView1.DeleteSelectedRows()
    End Sub

    Private Sub ViewBookingDetails()

        If GridView1.SelectedRowsCount = 1 Then
            frmEdit.bookingsList.Clear()
            Dim bookingId As Long
            bookingId = CInt(GridView1.GetFocusedRowCellValue("BookingID"))
            If bookingId > 0 Then
                frmEdit.bookingId = bookingId
                frmEdit.ShowDialog()
            End If
        ElseIf GridView1.SelectedRowsCount > 1 Then
            Dim bookingsList As New List(Of Integer)

            For Each i As Integer In GridView1.GetSelectedRows
                bookingsList.Add(GridView1.GetRowCellValue(i, "BookingID"))
            Next
            frmEdit.bookingsList = bookingsList
            frmEdit.ShowDialog()
        End If

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        ViewBookingDetails()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Theme = UserLookAndFeel.Default.SkinName.ToString
        My.Settings.Save()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        beDateFrom.EditValue = My.Settings.RibbonDateFrom
        beDateTo.EditValue = Today().AddYears(3)

        If My.Settings.Destination <> "" Then
            Try
                For x = 0 To GV.CurrentUser.UserDestinations.Count - 1
                    If GV.CurrentUser.UserDestinations(x).DestinationCode = My.Settings.Destination Then
                        beCountry.EditValue = My.Settings.Destination
                        Exit For
                    End If
                Next

            Catch ex As Exception

            End Try
        End If

        frmLogin.Close()
        If Not My.Settings.Theme = "" Then
            UserLookAndFeel.Default.SkinName = My.Settings.Theme.ToString()
        End If
    End Sub

    Private Sub btnSwitchUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSwitchUser.ItemClick
        frmLogin.ShowDialog()
        BookingDT.Reset()
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

    Private Sub beDateFrom_EditValueChanged(sender As Object, e As EventArgs) Handles beDateFrom.EditValueChanged
        My.Settings.RibbonDateFrom = beDateFrom.EditValue
        My.Settings.Save()
    End Sub

    Private Sub btnManageDestination_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDestination.ItemClick
        frmManageDestinations.ShowDialog()
    End Sub

    Private Sub btnManageMargin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnManageMargin.ItemClick
        frmManageMargin.ShowDialog()
    End Sub

    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ViewBookingDetails()
        ElseIf e.KeyCode = Keys.Delete Then
            RemoveRows()
        End If
    End Sub

    Private Sub beCountry_EditValueChanged(sender As Object, e As EventArgs) Handles beCountry.EditValueChanged
        My.Settings.Destination = beCountry.EditValue
        My.Settings.Save()
    End Sub

    Private Sub btnJunk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnJunk.ItemClick
        LoadData("AND Junk = 1 AND GwgStatus != 'Can'")
    End Sub

    Private Sub brnCanceled_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brnCanceled.ItemClick
        LoadData("AND GwgStatus = 'Can'")
    End Sub

    Private Sub btnMatching_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMatching.ItemClick
        Dim status As String
        status = " AND Junk = 0 AND GwgStatus != 'Can' AND dbo.NegativeMargin(BookingID) = 1 AND dbo.ExcessiveMargin(BookingID) = 1 AND dbo.Mismatch(BookingID) = 1"
        LoadData(status)
    End Sub

    Private Sub btnShowDefict_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowDefict.ItemClick
        Dim status As String = " AND Junk = 0 AND GwgStatus != 'Can' AND ("

        If Not bcExcessive.Checked And Not bcNegative.Checked And Not bcMismatch.Checked Then
            MsgBox("Please select at least one option!")
            Exit Sub
        End If

        If bcNegative.Checked Then
            status &= "dbo.NegativeMargin(BookingID) = 0"
        End If
        If bcExcessive.Checked Then
            If bcNegative.Checked Then
                status &= " OR "
            End If
            status &= "dbo.ExcessiveMargin(BookingID) = 0"
        End If
        If bcMismatch.Checked Then
            If bcNegative.Checked Or bcExcessive.Checked Then
                status &= " OR "
            End If
            status &= "dbo.Mismatch(BookingID) = 0"
        End If
        status &= ");"
        LoadData(status)

    End Sub

    Private Sub btnShow_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShow.ItemClick
        Dim status As String = " AND Junk = 0 AND GwgStatus != 'Can' AND ("
        If Not bcPendingDmc.Checked And Not bcPendingTo.Checked And Not bcFixedDmc.Checked And Not bcFixedTo.Checked And Not bcNewRecord.Checked Then
            MsgBox("Please select at least one option!")
            Exit Sub
        End If

        If bcPendingDmc.Checked Then
            status &= "dbo.Dispute(BookingID) = 'PENDING DMC'"
        End If

        If bcFixedDmc.Checked Then
            If bcPendingDmc.Checked Then
                status &= " OR "
            End If
            status &= "dbo.Dispute(BookingID) = 'FIXED DMC'"
        End If
        If bcPendingTo.Checked Then
            If bcPendingDmc.Checked Or bcFixedDmc.Checked Then
                status &= " OR "
            End If
            status &= "dbo.Dispute(BookingID) = 'PENDING T/O'"
        End If
        If bcFixedTo.Checked Then
            If bcPendingDmc.Checked Or bcFixedDmc.Checked Or bcPendingTo.Checked Then
                status &= " OR "
            End If
            status &= "dbo.Dispute(BookingID) = 'FIXED T/O'"
        End If
        If bcNewRecord.Checked Then
            If bcPendingDmc.Checked Or bcFixedDmc.Checked Or bcPendingTo.Checked Or bcFixedTo.Checked Then
                status &= " OR "
            End If
            status &= "dbo.Dispute(BookingID) IS NULL"
        End If
        status &= ");"
        LoadData(status)
    End Sub

    Private Sub btnAddDispute_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddDispute.ItemClick
        ViewBookingDetails()
    End Sub

    Private Sub btnTO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTO.ItemClick
        frmManageTourOperator.ShowDialog()
    End Sub

    Private Sub btnManageCurrency_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnManageCurrency.ItemClick
        frmCurrency.ShowDialog()
    End Sub

    Private Sub btnErrors_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnErrors.ItemClick
        Dim status As String
        status = " AND (dbo.ExcessiveMargin(BookingID) = 2 OR dbo.Mismatch(BookingID) = 2)"
        LoadData(status)
    End Sub

    Private Sub btnAbout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbout.ItemClick
        frmAbout.ShowDialog()
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        If GridView1.FocusedColumn.Caption = "PriceBreakdown" Then
            Dim link As String
            link = GridView1.GetFocusedRowCellValue("PriceBreakdown")
            If link <> "" Then
                Process.Start(link)
            End If
        End If
    End Sub
End Class
