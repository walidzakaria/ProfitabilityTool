Public Class FrmProgress
    Dim ToCancel As Boolean
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub peImage_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmProgress_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 100%
        ProgressBarControl1.EditValue = 0
        ProgressBarControl1.Properties.ShowTitle = True

        ProgressBarControl1.Properties.Step = 1
        ToCancel = False

    End Sub
    Private Function SaveRow(ByVal rowIndex As Integer) As Boolean
        Dim result As Boolean = True
        Dim query As String = ""

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


        If FrmMain.GridView1.GetRowCellValue(rowIndex, "BookingID").ToString = "0" Then

            With FrmMain.GridView1
                reference = .GetRowCellValue(rowIndex, "Reference").ToString
                hotelCode = .GetRowCellValue(rowIndex, "HotelCode").ToString
                hotelName = Replace(.GetRowCellValue(rowIndex, "HotelName").ToString, "'", "''")
                hotelCountry = .GetRowCellValue(rowIndex, "HotelCountry").ToString
                gwgStatus = .GetRowCellValue(rowIndex, "GwgStatus").ToString
                bookingStatus = .GetRowCellValue(rowIndex, "BookingStatus").ToString
                purchaseCurrency = .GetRowCellValue(rowIndex, "PurchaseCurrency").ToString
                purchasePrice = Val(.GetRowCellValue(rowIndex, "PurchasePrice").ToString.Replace(",", "")).ToString
                If purchasePrice.ToLower.Contains("e") Then
                    purchasePrice = "0"
                End If
                salesCurrency = .GetRowCellValue(rowIndex, "SalesCurrency").ToString
                salesPrice = Val(.GetRowCellValue(rowIndex, "SalesPrice").ToString.Replace(",", "")).ToString
                If salesPrice.ToLower.Contains("e") Then
                    salesPrice = "0"
                End If
                gwgHandlingFee = Val(.GetRowCellValue(rowIndex, "GwgHandlingFee").ToString.Replace(",", "")).ToString
                margin = Val(.GetRowCellValue(rowIndex, "Margin").ToString.Replace(",", "")).ToString
                currencyHotelTC = .GetRowCellValue(rowIndex, "CurrencyHotelTC").ToString
                netRateHotelTC = Val(.GetRowCellValue(rowIndex, "NetRateHotelTC").ToString.Replace(",", "")).ToString
                netRateHandlingTC = Val(.GetRowCellValue(rowIndex, "NetRateHandlingTC").ToString.Replace(",", "")).ToString
                checkHotel = .GetRowCellValue(rowIndex, "CheckHotel").ToString
                companyGroup = .GetRowCellValue(rowIndex, "CompanyGroup").ToString
                bookingDate = FrmMain.TextToDate(.GetRowCellValue(rowIndex, "BookingDate").ToString).ToString("MM/dd/yyyy")
                traveldate = FrmMain.TextToDate(.GetRowCellValue(rowIndex, "TravelDate").ToString).ToString("MM/dd/yyyy")
                roomType = .GetRowCellValue(rowIndex, "RoomType").ToString
                board = .GetRowCellValue(rowIndex, "Board").ToString
                duration = .GetRowCellValue(rowIndex, "Duration").ToString
                transferTo = .GetRowCellValue(rowIndex, "TransferTo").ToString
                transferFrom = .GetRowCellValue(rowIndex, "TransferFrom").ToString
                pax = .GetRowCellValue(rowIndex, "Pax").ToString
                adult = .GetRowCellValue(rowIndex, "Adult").ToString
                child = .GetRowCellValue(rowIndex, "Child").ToString
                importDate = FrmMain.TextToDate(.GetRowCellValue(rowIndex, "ImportDate").ToString).ToString("MM/dd/yyyy")
                mpImportDate = FrmMain.TextToDate(.GetRowCellValue(rowIndex, "MPImportDate").ToString).ToString("MM/dd/yyyy")
                incomingAgency = .GetRowCellValue(rowIndex, "IncomingAgency").ToString
                bookingStateDesc = .GetRowCellValue(rowIndex, "BookingStateDesc").ToString
                hotelFlag = .GetRowCellValue(rowIndex, "HotelFlag").ToString
                missingBookings = .GetRowCellValue(rowIndex, "MissingBookings").ToString
                marginCheck = .GetRowCellValue(rowIndex, "MarginCheck").ToString
                differenceTOPrice = .GetRowCellValue(rowIndex, "DifferenceTOPrice").ToString
                actionBy = .GetRowCellValue(rowIndex, "ActionBy").ToString
                priceBreakdown = .GetRowCellValue(rowIndex, "PriceBreakdown").ToString
                difference = (Val(salesPrice) - Val(netRateHotelTC)).ToString
            End With
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
                result = ExClass.QuerySet(query) = "True"
            End If

        End If

        Return result
    End Function
    Private Sub SaveBulk()
        Dim totalRows As Integer = FrmMain.GridView1.RowCount
        Dim done As Integer
        Dim success As Integer
        Dim failed As Integer
        Dim focusedRow As Integer
        ProgressBarControl1.Properties.Maximum = totalRows
        For x As Integer = 0 To totalRows - 1
            FrmMain.GridView1.FocusedRowHandle = focusedRow
            If ToCancel Then
                Exit For
            End If
            done += 1
            If SaveRow(focusedRow) Then
                success += 1
                FrmMain.GridView1.DeleteRow(focusedRow)
            Else
                failed += 1
                focusedRow += 1
            End If
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()

            labelStatus.Text = $"{done} processed of {totalRows}"
            labelSuccess.Text = $"Total success {success}"
            labelFailure.Text = $"Total failed {failed}"
            Application.DoEvents()
        Next

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ToCancel = True
    End Sub

    Private Sub FrmProgress_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SaveBulk()
    End Sub
End Class
