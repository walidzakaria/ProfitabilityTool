Public Class FrmImport
    Dim bookingsDatatable As DataTable
    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        Select Case e.Button.Properties.Caption
            Case "Close"
                Me.Close()
            Case "Browse"
                BrowseFile()
        End Select
    End Sub

    Private Sub BrowseFile()
        If XtraOpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            Dim files As List(Of String) = XtraOpenFileDialog1.FileNames.ToList

            For Each file In files
                LabelControl1.Text = $"Processing {files.IndexOf(file) + 1} of {files.Count} files"
                Application.DoEvents()
                Dim dt As DataTable = ExcelToDataTable.GetDatatable(file)
                ' Dim dt As DataTable = ParseExcel(file)
                SaveBulk(dt, file)
            Next
            LabelControl1.Text = "Done"
        End If
    End Sub

    'Private Function ParseExcel(fileName As String) As DataTable

    '    Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
    '    Dim xlWb As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Open(fileName, [ReadOnly]:=True)
    '    Dim xlSh As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(xlWb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
    '    Dim xlRange As Microsoft.Office.Interop.Excel.Range
    '    xlRange = xlSh.UsedRange

    '    Dim xlRows As Object(,)
    '    xlRows = CType(xlRange.Value, Object(,))
    '    Dim dt As New DataTable()


    '    dt.Columns.Add("Reference")
    '    dt.Columns.Add("Hotelcode")
    '    dt.Columns.Add("Hotelname")
    '    dt.Columns.Add("HotelCountry")
    '    dt.Columns.Add("GWGStatus")
    '    dt.Columns.Add("BookingStatus")
    '    dt.Columns.Add("PurchaseCurrency")
    '    dt.Columns.Add("PurchasePrice")
    '    dt.Columns.Add("SalesCurrency")
    '    dt.Columns.Add("SalesPrice")
    '    dt.Columns.Add("Handling Fee")
    '    dt.Columns.Add("Margin")
    '    dt.Columns.Add("difference")
    '    dt.Columns.Add("CurrencyHotelTC")
    '    dt.Columns.Add("NetRateHotelTC")
    '    dt.Columns.Add("NetRateHandlingTC")
    '    dt.Columns.Add("CheckHotel")
    '    dt.Columns.Add("Company_Group")
    '    dt.Columns.Add("Bookingdate")
    '    dt.Columns.Add("Traveldate")
    '    dt.Columns.Add("Roomtype")
    '    dt.Columns.Add("Board")
    '    dt.Columns.Add("Duration")
    '    dt.Columns.Add("TransferTo")
    '    dt.Columns.Add("TransferFrom")
    '    dt.Columns.Add("Pax")
    '    dt.Columns.Add("Adult")
    '    dt.Columns.Add("Child")
    '    dt.Columns.Add("ImportDate")
    '    dt.Columns.Add("MPImportDate")
    '    dt.Columns.Add("IncomingAgency")
    '    dt.Columns.Add("BookingStateDesc")
    '    dt.Columns.Add("Hotel Flag")
    '    dt.Columns.Add("Missing Bookings")
    '    dt.Columns.Add("Margin Check")
    '    dt.Columns.Add("Difference TO Price")
    '    dt.Columns.Add("Action By")
    '    dt.Columns.Add("Status")
    '    dt.Columns.Add("Comments")
    '    dt.Columns.Add("Difference Reason")
    '    dt.Columns.Add("Price Breakdown")
    '    Dim liCells As New List(Of Object)()

    '    For excelRow As Integer = xlRows.GetLowerBound(0) + 1 To xlRows.GetUpperBound(0)

    '        For excelColumn As Integer = xlRows.GetLowerBound(1) To xlRows.GetUpperBound(1)

    '            'Populate DataTable here
    '            Dim excelValue = xlRows(excelRow, excelColumn)
    '            liCells.Add(excelValue)

    '            Console.WriteLine(String.Concat("At row ", excelRow, " column ", excelColumn, " the value is ", excelValue))
    '        Next excelColumn
    '        dt.Rows.Add(liCells)
    '        liCells.Clear()
    '    Next excelRow

    '    xlRange = Nothing
    '    xlSh = Nothing
    '    xlWb.Close()
    '    xlWb = Nothing
    '    xlApp.Quit()
    '    xlApp = Nothing


    '    'Dim conStr As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={fileName};Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'"
    '    'Dim conExcel As New OleDbConnection(conStr)
    '    'Dim cmdExcel As New OleDbCommand()
    '    'Dim oda As New OleDbDataAdapter()
    '    'cmdExcel.Connection = conExcel
    '    ''Get the name of First Sheet
    '    'conExcel.Open()
    '    'Dim dtExcelSchema = conExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
    '    'Dim SheetName As String = ""
    '    'If dtExcelSchema.Rows.Count > 0 Then
    '    '    SheetName = dtExcelSchema.Rows(dtExcelSchema.Rows.Count - 1)("TABLE_NAME").ToString()
    '    'End If
    '    'conExcel.Close()
    '    ''Read Data from First Sheet
    '    'conExcel.Open()
    '    'cmdExcel.CommandText = "SELECT * From [" & SheetName & "]"
    '    'oda.SelectCommand = cmdExcel
    '    'Dim dt As New DataTable()
    '    'oda.Fill(dt)
    '    'dt.TableName = SheetName.ToString().Replace("$", "")
    '    'conExcel.Close()

    '    Return dt

    'End Function

    Private Sub FrmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookingsDatatable = New DataTable()
        bookingsDatatable.Columns.Add("Sr")
        bookingsDatatable.Columns.Add("FileName")
        bookingsDatatable.Columns.Add("Reference")
        bookingsDatatable.Columns.Add("Status")
        GridControl1.DataSource = bookingsDatatable

    End Sub

    Private Sub SaveBulk(inputDT As DataTable, fileName As String)
        Dim totalRows As Integer = inputDT.Rows.Count
        Dim done As Integer
        Dim success As Integer
        Dim failed As Integer
        ProgressBarControl1.Properties.Maximum = totalRows
        Dim saveResult As String
        For x As Integer = 0 To totalRows - 1

            done += 1
            saveResult = SaveRow(inputDT.Rows(x))
            If saveResult = "True" Then
                success += 1
                bookingsDatatable.Rows.Add({x + 1, fileName, inputDT.Rows(x)(0), "Success"})
            Else
                failed += 1
                bookingsDatatable.Rows.Add({x + 1, fileName, inputDT.Rows(x)(0), saveResult})
            End If
            GridView1.MoveLast()
            ProgressBarControl1.EditValue = x + 1
            ProgressBarControl1.Update()

            labelStatus.Text = $"{done} processed of {totalRows}"
            labelSuccess.Text = $"Total success {success}"
            labelFailure.Text = $"Total failed {failed}"
            Application.DoEvents()
        Next

    End Sub

    Private Function SaveRow(bookingRow As DataRow) As String
        Dim result As String = ""
        Dim query As String

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
        Dim junk As String


        reference = bookingRow(0).ToString
        hotelCode = bookingRow(1).ToString
        hotelName = bookingRow(2).ToString.Replace("'", "''")
        hotelCountry = bookingRow(3).ToString
        gwgStatus = bookingRow(4).ToString
        bookingStatus = bookingRow(5).ToString
        purchaseCurrency = bookingRow(6).ToString
        purchasePrice = bookingRow(7).ToString.Replace(",", "").ToString
        If purchasePrice.ToLower.Contains("e") Then
            purchasePrice = "0"
        End If
        salesCurrency = bookingRow(8).ToString

        salesPrice = Val(bookingRow(9).ToString.Replace(",", "")).ToString
        If salesPrice.ToLower.Contains("e") Then
            salesPrice = "0"
        End If
        gwgHandlingFee = Val(bookingRow(10)).ToString.Replace(",", "").ToString
        margin = Val(bookingRow(11).ToString.Replace(",", "")).ToString
        currencyHotelTC = bookingRow(13).ToString
        netRateHotelTC = Val(bookingRow(14).ToString.Replace(",", "")).ToString
        netRateHandlingTC = Val(bookingRow(15).ToString.Replace(",", "")).ToString
        checkHotel = bookingRow(16).ToString
        companyGroup = bookingRow(17).ToString
        bookingDate = FrmMain.TextToDate(bookingRow(18).ToString).ToString("MM/dd/yyyy")
        traveldate = FrmMain.TextToDate(bookingRow(19).ToString).ToString("MM/dd/yyyy")
        roomType = bookingRow(20).ToString
        board = bookingRow(21).ToString
        duration = bookingRow(22).ToString
        transferTo = bookingRow(23).ToString
        transferFrom = bookingRow(24).ToString
        pax = bookingRow(25).ToString
        adult = bookingRow(26).ToString
        child = bookingRow(27).ToString
        importDate = FrmMain.TextToDate(bookingRow(28).ToString).ToString("MM/dd/yyyy")
        mpImportDate = FrmMain.TextToDate(bookingRow(29).ToString).ToString("MM/dd/yyyy")
        incomingAgency = bookingRow(30).ToString
        bookingStateDesc = bookingRow(31).ToString
        hotelFlag = bookingRow(32).ToString
        missingBookings = bookingRow(33).ToString
        marginCheck = bookingRow(34).ToString
        differenceTOPrice = bookingRow(34).ToString
        actionBy = bookingRow(35).ToString
        priceBreakdown = bookingRow(40).ToString
        difference = (Val(salesPrice) - Val(netRateHotelTC)).ToString


        If hotelCode <> "" Then
            If purchaseCurrency = "" Then
                purchaseCurrency = currencyHotelTC
            End If
            If salesCurrency = "" Then
                salesCurrency = purchaseCurrency
            End If

            junk = (Booking.CheckJunk(gwgStatus, marginCheck, Val(purchasePrice), Val(salesPrice), Val(netRateHotelTC), hotelName)).ToString
            query = String.Format("EXEC dbo.SaveBooking 0, '{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', '{6}',
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
                                                junk, bookingStatus, mpImportDate)
            result = ExClass.QuerySet(query)
        End If

        Return result
    End Function

    Private Function MakeTableFromRange(rng As Microsoft.Office.Interop.Excel.Range) As DataTable
        Dim table = New DataTable()
        For Each column In rng
            table.Columns.Add(column)
        Next

    End Function
End Class