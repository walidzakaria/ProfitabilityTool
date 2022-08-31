Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors

Partial Public Class FrmMain
    Dim bookingDT As New DataTable()
    ReadOnly defaultGridLayout As System.IO.Stream = New System.IO.MemoryStream()

    Private Sub SetCheckedRibbonButton(Optional excludedButton As DevExpress.XtraBars.BarButtonItem = Nothing)
        For Each item In RibbonControl1.Items
            If TypeOf (item) Is DevExpress.XtraBars.BarButtonItem Then
                item.Down = False
            End If
        Next
        If Not excludedButton Is Nothing Then
            excludedButton.Down = True
        End If
    End Sub

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
    Private Sub BtnImport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnImport.ItemClick
        Wait(True)
        NavigationFrame1.SelectedPageIndex = 1
        ResetGridLayout()

        Dim dt As DataTable = ParseText()
        GridControl1.DataSource = dt
        GridView1.BestFitColumns()
        Wait(False)
        SetCheckedRibbonButton(BtnImport)
        'FrmImport.ShowDialog()
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
        result.Columns.Add("Section")

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
            XtraMessageBox.Show(errorMessage)
        End If
        Return result
    End Function


    Private Sub BtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSave.ItemClick
        FrmProgress.ShowDialog()
        SetCheckedRibbonButton()
    End Sub

    Public Sub UpdateCertainRow(ByVal rowHandle As Integer, ByVal booking As Booking)

        For x = 0 To bookingDT.Columns.Count - 1
            bookingDT.Columns(x).ReadOnly = False
        Next

        With GridView1
            .SetRowCellValue(rowHandle, "Reference", booking.Reference)
            .SetRowCellValue(rowHandle, "HotelCode", booking.HotelCode)
            .SetRowCellValue(rowHandle, "HotelName", booking.HotelName)
            .SetRowCellValue(rowHandle, "HotelCountry", booking.CountryCode)
            .SetRowCellValue(rowHandle, "GwgStatus", booking.GwgStatus)
            .SetRowCellValue(rowHandle, "BookingStatus", booking.BookingStatus)
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
            .SetRowCellValue(rowHandle, "MPImportDate", booking.MPImportDate)
            .SetRowCellValue(rowHandle, "IncomingAgency", booking.IncomingAgency)
            .SetRowCellValue(rowHandle, "BookingStateDesc", booking.BookingStateDesc)
            .SetRowCellValue(rowHandle, "HotelFlag", booking.HotelFlag)
            .SetRowCellValue(rowHandle, "MissingBookings", booking.MissingBookings)
            .SetRowCellValue(rowHandle, "MarginCheck", booking.MarginCheck)
            .SetRowCellValue(rowHandle, "DifferenceTOPrice", booking.DifferenceToPrice)
            .SetRowCellValue(rowHandle, "ActionBy", booking.LastUser.Username)
            .SetRowCellValue(rowHandle, "Status", booking.Status)
            .SetRowCellValue(rowHandle, "Comments", booking.Comments)
            .SetRowCellValue(rowHandle, "AdjustedPrice", booking.AdjustedPrice)
            .SetRowCellValue(rowHandle, "PriceBreakdown", booking.PriceBreakdown)
            .SetRowCellValue(rowHandle, "Section", booking.Section)
        End With

        GridView1.RefreshData()
    End Sub

    Public Sub UpdateCertainRow(ByVal adjustPrice As Boolean, ByVal booking As Booking)

        For x = 0 To bookingDT.Columns.Count - 1
            bookingDT.Columns(x).ReadOnly = False
        Next

        For x = 0 To GridView1.RowCount - 1
            If GridView1.IsRowSelected(x) And FrmEdit.BookingsList.Contains(CInt(GridView1.GetRowCellValue(x, "BookingID"))) Then
                With GridView1

                    .SetRowCellValue(x, "ActionBy", booking.LastUser.Username)
                    .SetRowCellValue(x, "Status", booking.Status)
                    .SetRowCellValue(x, "Comments", booking.Comments)
                    If adjustPrice Then
                        .SetRowCellValue(x, "AdjustedPrice", booking.AdjustedPrice)
                    End If
                    .SetRowCellValue(x, "Action", booking.ActionBy)
                    .SetRowCellValue(x, "Section", booking.Section)
                End With
            End If
        Next

    End Sub
    Public Function TextToDate(ByVal dateText As String) As Date
        Dim result As Date = New Date(1900, 1, 1)
        Dim tempDate() As String
        dateText = dateText.Replace("/", ".")
        tempDate = Split(dateText, ".")
        If dateText <> "" Then
            Try
                If Len(tempDate(0)) = 2 Then
                    result = New Date(CInt(tempDate(2).Substring(0, 4)), CInt(tempDate(1)), CInt(tempDate(0)))
                Else
                    result = New Date(CInt(tempDate(0).Substring(0, 4)), CInt(tempDate(1)), CInt(tempDate(2)))
                End If

            Catch ex As Exception

            End Try

        End If

        Return result
    End Function

    Private Function LoadData(ByVal status As String, ByVal allCountries As Boolean) As Boolean
        NavigationFrame1.SelectedPageIndex = 1
        If BeCountry.EditValue Is Nothing And Not allCountries Then
            XtraMessageBox.Show("Please select destination!")
            Return False
        ElseIf GV.CurrentUser.UserOperators = "" And Not allCountries Then
            XtraMessageBox.Show("You don't have permission to view data!")
            Return False
        End If

        Wait(True)


        Dim startDate, endDate, importFrom, importTill As Date
        Dim destination As String
        startDate = CDate(BeDateFrom.EditValue)
        endDate = CDate(BeDateTo.EditValue)
        destination = CStr(BeCountry.EditValue)
        importFrom = CDate(BeImportFrom.EditValue)
        importTill = CDate(BeImportTill.EditValue)


        Dim querySelect As String = "SELECT BookingID, Reference, HotelCode, HotelName, HotelCountry, GwgStatus, PurchaseCurrency, PurchasePrice,
                                    SalesCurrency, SalesPrice, GwgHandlingFee, Margin, Difference, CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC,
                                    CheckHotel, CompanyGroup, BookingDate, TravelDate, RoomType, Board, Duration, TransferTo, TransferFrom,
                                    Pax, Adult, Child, ImportDate, IncomingAgency, BookingStateDesc, HotelFlag, MissingBookings, MarginCheck,
                                    DifferenceTOPrice, [Login].Username AS ActionBy, [Status], Comments,
                                    AdjustedPrice, PriceBreakdown, Booking.LoginID, Junk, BookingStatus, MPImportDate, Section
                                    FROM Booking 
                                    JOIN [Login] ON [Login].LoginID = Booking.ActionBy"


        Dim query As String
        If Not allCountries Then
            query = String.Format("{0}
                              WHERE HotelCountry = '{1}' AND (TravelDate BETWEEN '{2}' AND '{3}') AND CompanyGroup IN {4} {5} AND ToolImport BETWEEN '{6}' AND '{7}' " _
                              , querySelect, destination,
                              startDate.ToString("MM/dd/yyyy"), endDate.ToString("MM/dd/yyyy"),
                              GV.CurrentUser.UserOperators, status,
                              importFrom.ToString("MM/dd/yyyy") & " 00:00:00.001",
                              importTill.ToString("MM/dd/yyyy") & " 23:59:59.999")
        Else
            query = String.Format("{0}
                              WHERE (TravelDate BETWEEN '{1}' AND '{2}' {3}) AND ToolImport BETWEEN '{4}' AND '{5}' " _
                              , querySelect,
                              startDate.ToString("MM/dd/yyyy"), endDate.ToString("MM/dd/yyyy"), status,
                              importFrom.ToString("MM/dd/yyyy") & " 00:00:00.001",
                              importTill.ToString("MM/dd/yyyy") & " 23:59:59.999")

        End If

        bookingDT = ExClass.QueryGet(query)
        GridControl1.DataSource = bookingDT

        Wait(False)
        Return True
    End Function

    Private Sub BtnLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLoad.ItemClick
        If LoadData("", False) Then
            SetCheckedRibbonButton(BtnLoad)
        End If
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
                If Not IsReadOnlyBookings(True, bookingId.ToString) Then
                    LockBookings(bookingId.ToString, True)
                    FrmEdit.BookingId = bookingId
                    Wait(False)
                    FrmEdit.ShowDialog()
                    LockBookings(bookingId.ToString, False)
                End If
            End If
        ElseIf GridView1.SelectedRowsCount > 1 Then
            Dim bookingsList As New List(Of Long)

            For Each i As Integer In GridView1.GetSelectedRows
                bookingsList.Add(CInt(GridView1.GetRowCellValue(i, "BookingID")))
            Next

            ' Check if some bookings are locked.
            Dim bookings As String = String.Join(",", bookingsList.[Select](Function(i) i.ToString()).ToArray())
            If Not IsReadOnlyBookings(False, bookings) Then
                LockBookings(bookings, True)
                FrmEdit.BookingsList = bookingsList
                Wait(False)
                FrmEdit.ShowDialog()
                LockBookings(bookings, False)
            End If
        End If

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        ViewBookingDetails()
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim mboxResult As DialogResult = XtraMessageBox.Show("Are you sure you want to close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mboxResult = DialogResult.Yes Then
                LockBookings("", False)
                My.Settings.Theme = UserLookAndFeel.Default.SkinName.ToString
                My.Settings.Save()
                GridView1.SaveLayoutToRegistry("PrToolLayout")
                Application.Exit()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChartControl1.DataSource = Nothing
        ChartControl2.DataSource = Nothing
        ChartControl3.DataSource = Nothing
        ChartControl4.DataSource = Nothing
        BeDateFrom.EditValue = My.Settings.RibbonDateFrom
        BeDateTo.EditValue = Today().AddYears(3)
        BeImportFrom.EditValue = Today()
        BeImportTill.EditValue = Today()

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
    End Sub

    Private Sub BtnManageUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnManageUsers.ItemClick
        FrmManageUsers.ShowDialog()
    End Sub

    Private Sub BeDateFrom_EditValueChanged()
        My.Settings.RibbonDateFrom = CDate(BeDateFrom.EditValue)
        My.Settings.Save()

        If NavigationFrame1.SelectedPageIndex = 0 Then
            LoadCharts()
        End If

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

    Private Sub BeCountry_EditValueChanged()
        My.Settings.Destination = CStr(BeCountry.EditValue)
        My.Settings.Save()
        If NavigationFrame1.SelectedPageIndex = 0 Then
            LoadCharts()
        End If

    End Sub

    Private Sub BtnJunk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnJunk.ItemClick
        If LoadData(" AND Junk = 1 ", False) Then
            SetCheckedRibbonButton(BtnJunk)
        End If
    End Sub

    Private Sub BtnCanceled_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCanceled.ItemClick
        Dim status As String
        status = " AND Junk = 0 AND GwgStatus = 'Can' AND MismatchCalc = 0 "
        If LoadData(status, False) Then
            SetCheckedRibbonButton(BtnCanceled)
        End If
    End Sub

    Private Sub BtnMatching_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMatching.ItemClick
        Dim status As String
        status = " AND Junk = 0 AND GwgStatus != 'Can' AND NegativeMargin = 0 
                    AND ExcessiveMargin = 0 AND MismatchCalc = 0 "
        If LoadData(status, False) Then
            SetCheckedRibbonButton(BtnMatching)
        End If
    End Sub

    Private Sub BtnShowDefict_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnShowDefict.ItemClick
        Dim status As String = " AND Junk = 0 AND ([Status] IS NULL OR [Status] = '') AND ("

        If Not BcExcessive.Checked And Not BcNegative.Checked And Not BcMismatch.Checked Then
            XtraMessageBox.Show("Please select at least one option!")
            BtnShowDefict.Down = False
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
        status &= ")"
        If LoadData(status, False) Then
            SetCheckedRibbonButton(BtnShowDefict)
        End If

    End Sub

    Private Sub BtnShow_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnShow.ItemClick
        Dim status As String = " AND Junk = 0 AND ("
        If Not BcPendingDmc.Checked And Not BcPendingTo.Checked _
            And Not BcFixedDmc.Checked And Not BcFixedTo.Checked And Not BcCannotFix.Checked Then
            XtraMessageBox.Show("Please select at least one option!")
            BtnShow.Down = False
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
        If BcCannotFix.Checked Then
            If BcPendingDmc.Checked Or BcFixedDmc.Checked Or BcPendingTo.Checked Or BcFixedTo.Checked Then
                status &= " OR "
            End If
            status &= "[Status] = 'CANNOT FIX'"
        End If
        status &= ")"
        If LoadData(status, False) Then
            SetCheckedRibbonButton(BtnShow)
        End If
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
        If LoadData(status, True) Then
            SetCheckedRibbonButton(BtnErrors)
        End If
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

        GridView1.RestoreLayoutFromRegistry("PrToolLayout")
        ExClass.AuthorizeColumns()
        LoadCharts()
        AddHandler BeCountry.EditValueChanged, AddressOf BeCountry_EditValueChanged
        AddHandler BeDateTo.EditValueChanged, AddressOf BeDateFrom_EditValueChanged
        AddHandler BeDateFrom.EditValueChanged, AddressOf BeDateFrom_EditValueChanged
    End Sub

    Private Sub LoadCharts()
        Wait(True)
        Dim startDate, endDate As Date
        Dim destination As String
        startDate = CDate(BeDateFrom.EditValue)
        endDate = CDate(BeDateTo.EditValue)
        destination = CStr(BeCountry.EditValue)

        ' Destination Status
        Dim query As String = $"SELECT HotelCountry AS Country,
            SUM(IIF(NegativeMargin = 1 OR ExcessiveMargin = 1 OR MismatchCalc = 1, 0, 1)) AS Matching,
            SUM(CONVERT(TINYINT, NegativeMargin)) AS Negative,
            SUM(CONVERT(TINYINT, ExcessiveMargin)) AS Excessive,
            SUM(CONVERT(TINYINT, MismatchCalc)) AS Mismatch, COUNT(*) AS Total
            FROM Booking
            WHERE TravelDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
            GROUP BY HotelCountry;"
        Dim destinationDT As DataTable = ExClass.QueryGet(query)
        ChartControl1.DataSource = destinationDT

        ' Booking Disputes
        query = $"SELECT IIF([Status] = '', 'NEW', [Status]) AS [Status], COUNT(*) AS Number
                FROM Booking
                WHERE HotelCountry = '{destination}'
                AND TravelDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
                GROUP BY [Status];"

        Dim disputesDT As DataTable = ExClass.QueryGet(query)
        ChartControl2.DataSource = disputesDT

        ' Company Status
        query = $"SELECT CompanyGroup AS Company, COUNT(*) AS Number
                FROM Booking
                WHERE HotelCountry = '{destination}'
                AND TravelDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
                GROUP BY CompanyGroup;"
        Dim companyDT As DataTable = ExClass.QueryGet(query)
        ChartControl3.DataSource = companyDT

        ' Section Status
        query = $"SELECT Section, COUNT(*) AS Number
                FROM Booking
                WHERE HotelCountry = '{destination}'
                AND TravelDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
                GROUP BY Section;"

        Dim sectionDT As DataTable = ExClass.QueryGet(query)
        ChartControl4.DataSource = sectionDT
        Wait(False)
    End Sub

    Private Sub ResetGridLayout()
        GridView1.RestoreLayoutFromStream(defaultGridLayout)
        ExClass.AuthorizeColumns()
        defaultGridLayout.Seek(0, System.IO.SeekOrigin.Begin)
    End Sub

    Private Function IsReadOnlyBookings(ByVal singleBooking As Boolean, ByVal bookingIDs As String) As Boolean
        Dim result As Boolean
        If singleBooking Then
            Dim dt As DataTable = IsLocked(bookingIDs)
            If dt.Rows.Count > 0 Then
                Dim message As String = String.Format("The booking will open as Read-Only as it's locked by user '{0}' since '{1}'.",
                                                      dt.Rows(0)(1), CDate(dt.Rows(0)(2)).ToString("HH:mm"))
                XtraMessageBox.Show(message)
                FrmEdit.NoSave = True
                result = True
            Else
                FrmEdit.NoSave = False
                result = False
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


                XtraMessageBox.Show(message)
                FrmEdit.NoSave = True
                result = True
            Else
                FrmEdit.NoSave = False
                result = False
            End If
        End If
        Return result
    End Function
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
                        UPDATE Booking SET Locked = {0}, LockTime = GETDATE() WHERE BookingID IN ({1}) AND Locked IS NULL
                    ", GV.CurrentUser.LoginId.ToString, bookingIDs)
        Else


            If bookingIDs <> "" Then
                query = String.Format("
                        UPDATE Booking SET Locked = NULL, LockTime = NULL WHERE BookingID IN ({0}) AND Locked = {1}
                    ", bookingIDs, GV.CurrentUser.LoginId.ToString)
            Else
                query = String.Format("
                        UPDATE Booking SET Locked = NULL, LockTime = NULL WHERE Locked = {0}
                    ", GV.CurrentUser.LoginId.ToString)
            End If
        End If

        ExClass.QuerySet(query)

    End Sub

    Private Sub BtnSection_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSection.ItemClick
        FrmManageSection.ShowDialog()
    End Sub

    Private Sub BtnResetGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnResetGrid.ItemClick
        ResetGridLayout()
    End Sub

    Private Sub RepositoryItemTextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemTextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ViewBookingDetails()
        End If
    End Sub

    Private Sub BtnReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnReport.ItemClick
        NavigationFrame1.SelectedPageIndex = 0
        LoadCharts()
        SetCheckedRibbonButton(BtnReport)
    End Sub

    Private Sub BeDateTo_EditValueChanged()
        If NavigationFrame1.SelectedPageIndex = 0 Then
            LoadCharts()
        End If
    End Sub

    Private Sub RefreshCharts()
        NavigationFrame1.SelectedPageIndex = 0
        LoadCharts()
        SetCheckedRibbonButton(BtnReport)
    End Sub

    Private Sub ChartControl3_DoubleClick(sender As Object, e As EventArgs) Handles ChartControl3.DoubleClick
        If ChartControl3.Dock = DockStyle.Fill Then
            ChartControl3.Dock = DockStyle.None
            ChartControl3.Left = 12
            ChartControl3.Top = 8
            ChartControl1.Visible = True
            ChartControl2.Visible = True
            ChartControl4.Visible = True
        Else
            ChartControl1.Visible = False
            ChartControl2.Visible = False
            ChartControl4.Visible = False
            ChartControl3.Dock = DockStyle.Fill
        End If
    End Sub


    Private Sub ChartControl2_DoubleClick(sender As Object, e As EventArgs) Handles ChartControl2.DoubleClick
        If ChartControl2.Dock = DockStyle.Fill Then
            ChartControl2.Dock = DockStyle.None
            ChartControl2.Left = 474
            ChartControl2.Top = 8
            ChartControl1.Visible = True
            ChartControl3.Visible = True
            ChartControl4.Visible = True
        Else
            ChartControl1.Visible = False
            ChartControl3.Visible = False
            ChartControl4.Visible = False
            ChartControl2.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ChartControl1_DoubleClick(sender As Object, e As EventArgs) Handles ChartControl1.DoubleClick
        If ChartControl1.Dock = DockStyle.Fill Then
            ChartControl1.Dock = DockStyle.None
            ChartControl1.Left = 12
            ChartControl1.Top = 289
            ChartControl2.Visible = True
            ChartControl3.Visible = True
            ChartControl4.Visible = True
        Else
            ChartControl2.Visible = False
            ChartControl3.Visible = False
            ChartControl4.Visible = False
            ChartControl1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub FrmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ChartControl3.Left = 12
            ChartControl3.Top = 8
            ChartControl1.Visible = True
            ChartControl2.Visible = True
            ChartControl3.Visible = True
            ChartControl4.Visible = True
            ChartControl2.Left = 474
            ChartControl2.Top = 8
            ChartControl1.Left = 12
            ChartControl1.Top = 289
            ChartControl4.Top = 8
            ChartControl4.Left = 921
            ChartControl1.Dock = DockStyle.None
            ChartControl2.Dock = DockStyle.None
            ChartControl3.Dock = DockStyle.None
            ChartControl4.Dock = DockStyle.None

        End If
    End Sub

    Private Sub ChartControl4_DoubleClick(sender As Object, e As EventArgs) Handles ChartControl4.DoubleClick
        If ChartControl4.Dock = DockStyle.Fill Then
            ChartControl4.Dock = DockStyle.None
            ChartControl4.Left = 921
            ChartControl4.Top = 8
            ChartControl2.Visible = True
            ChartControl3.Visible = True
            ChartControl1.Visible = True
        Else
            ChartControl2.Visible = False
            ChartControl3.Visible = False
            ChartControl1.Visible = False
            ChartControl4.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub BtnUpload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUpload.ItemClick
        FrmImport.ShowDialog()
    End Sub

    Private Sub btnBulkComment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBulkComment.ItemClick
        FrmImportComment.ShowDialog()
    End Sub
End Class
