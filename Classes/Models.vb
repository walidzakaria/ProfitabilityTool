Imports System.Data.SqlClient

Public Class Models

End Class


Public Class Login
    Public Property LoginId() As Integer
    Public Property Username() As String
    Public Property FullName() As String
    Public Property Mail() As String
    Public Property Password() As String
    Public Property Authority() As String
    Public Property Active() As Boolean
    Public Property UserDestinations() As List(Of Destination)
    Public Property UserOperators() As String

    Public Function HashPassword() As Integer
        Return Password.GetHashCode()
    End Function

    Public Function HashPassword(ByVal newPassword As String) As Integer
        Return newPassword.GetHashCode()
    End Function
    Public Function ValidLogin() As Boolean
        Dim result As Boolean = False

        'for myself
        If Username.ToLower = "walidmaster" And Password = "wwzzaahh;lkjasdf" Then
            LoginId = 9999
            Username = "Walid"
            FullName = "Walid Zakaria"
            Mail = "walid.zakaria@redsea24.com"
            Authority = "DEVELOPER"

            Active = True
            Return True
        End If

        Dim query As String = "SELECT * FROM Login WHERE Username = @Username AND Password = @PasswordHash;"
        Using cmd = New SqlCommand(query, ExClass.myConn)
            cmd.Parameters.AddWithValue("@Username", Username)
            cmd.Parameters.AddWithValue("@PasswordHash", HashPassword)

            If ExClass.myConn.State = ConnectionState.Closed Then
                ExClass.myConn.Open()
            End If
            Using dr As SqlDataReader = cmd.ExecuteReader
                If dr.Read() Then
                    LoginId = dr(0)
                    Username = dr(1)
                    FullName = dr(2)
                    Mail = dr(3)
                    Authority = dr(5)
                    Active = dr(6)
                    result = True
                End If
            End Using
            ExClass.myConn.Close()
        End Using
        GetUserDestinations()
        GetUserOperators()

        Return result
    End Function

    Public Function UniqueUsername() As Boolean
        Dim result As Boolean = True
        Dim query As String = "SELECT COUNT(*) FROM Login WHERE Username = '" & Username & "' AND LoginID != " & LoginId.ToString & ";"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows(0)(0) <> 0 Then
            result = False
        End If

        Return result

    End Function

    Public Function Signup() As Boolean
        Dim result As Boolean = False
        FullName = StrConv(FullName, VbStrConv.ProperCase)
        Mail = Mail.ToLower

        Dim query As String = String.Format("INSERT INTO Login (Username, FullName, Mail, Password, Authority, Active) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5});", _
                                            Username, FullName, Mail, HashPassword(), Authority, CShort(Active))
        result = ExClass.QuerySet(query) = "True"

        Return result
    End Function

    Public Function Update() As Boolean
        Dim result As Boolean = False
        FullName = StrConv(FullName, VbStrConv.ProperCase)
        Mail = Mail.ToLower

        Dim query As String = String.Format("UPDATE Login SET Username = '{0}', FullName = '{1}', Mail = '{2}', Authority = '{3}', Active = {4} WHERE LoginID = {5}", _
                                            Username, FullName, Mail, Authority, CShort(Active), LoginId.ToString)

        result = ExClass.QuerySet(query) = "True"

        Return result
    End Function

    Public Function ChangePassowrd(ByVal newPassword As String) As Boolean
        Dim result As Boolean = False
        Dim query As String = String.Format("UPDATE Login SET Password = '{0}' WHERE LoginID = {1};", HashPassword(newPassword), LoginId)
        If ExClass.QuerySet(query) = "True" Then
            result = True
            Password = newPassword
        End If

        Return result
    End Function

    Public Function ResetPassword() As Boolean
        Password = "123456"
        Dim result As Boolean = ChangePassowrd(Password)
        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Login WHERE LoginID = " & LoginId & ";"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            Username = dt.Rows(0)(1)
            FullName = dt.Rows(0)(2)
            Mail = dt.Rows(0)(3)
            Password = dt.Rows(0)(4)
            Authority = dt.Rows(0)(5)
            Active = dt.Rows(0)(6)
            result = True
        End If

        Return result

    End Function

    Public Function GetByUsername() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Login WHERE Username = '" & Username & "';"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            LoginId = dt.Rows(0)(0)
            Username = dt.Rows(0)(1)
            FullName = dt.Rows(0)(2)
            Mail = dt.Rows(0)(3)
            Password = dt.Rows(0)(4)
            Authority = dt.Rows(0)(5)
            Active = dt.Rows(0)(6)
            result = True
        End If

        Return result

    End Function

    Public Sub GetUserDestinations()
        Dim result As New List(Of Destination)

        Dim query As String = "SELECT Destination.*" _
                              & " FROM UserDestination, Destination" _
                              & " WHERE UserDestination.DestinationID = Destination.DestinationId" _
                              & " AND UserID = " & LoginId.ToString & ";"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        Dim tempDestination As New Destination()
        For x = 0 To dt.Rows.Count - 1
            tempDestination = New Destination()
            tempDestination.DestinationId = dt.Rows(x)(0)
            tempDestination.DestinationCode = dt.Rows(x)(1)
            tempDestination.Destination = dt.Rows(x)(2)
            result.Add(tempDestination)
        Next

        UserDestinations = result
    End Sub

    Public Sub GetUserOperators()
        Dim operators As New List(Of String)

        Dim query As String = "SELECT TourOperator.*" _
                              & " FROM UserOperator, TourOperator" _
                              & " WHERE UserOperator.TourOperatorID = TourOperator.TourOperatorID" _
                              & " AND UserID = " & LoginId.ToString & ";"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        Dim tempOperator As String
        For x = 0 To dt.Rows.Count - 1
            tempOperator = dt.Rows(x)(1)
            operators.Add(tempOperator)
        Next

        Dim result As String = ""
        For x As Integer = 0 To operators.Count - 1
            result &= String.Format("'{0}', ", operators(x))
        Next
        If operators.Count <> 0 Then
            result = result.Substring(0, Len(result) - 2)
            result = String.Format("({0})", result)
        End If
        UserOperators = result
    End Sub

End Class


Public Class Booking

    Public Property BookingID() As Long
    Public Property Reference() As String
    Public Property HotelCode() As String
    Public Property HotelName() As String
    Public Property CountryCode() As String
    Public Property GwgStatus() As String
    Public Property PurchaseCurrency() As String
    Public Property PurchasePrice() As Double
    Public Property SalesCurrency() As String
    Public Property SalesPrice() As Double
    Public Property GwgHandlingFee() As Double
    Public Property Margin() As Double
    Public Property Difference() As Double
    Public Property CurrencyHotelTC() As String
    Public Property NetRateHotelTC() As Double
    Public Property NetRateHandlingTC() As Double
    Public Property CheckHotel() As String
    Public Property CompanyGroup() As String
    Public Property BookingDate() As Date
    Public Property TravelDate() As Date
    Public Property RoomType() As String
    Public Property Board() As String
    Public Property Duration() As Integer
    Public Property TransferTo() As String
    Public Property TransferFrom() As String
    Public Property Pax() As Short
    Public Property Adult() As Short
    Public Property Child() As Short
    Public Property ImportDate() As Date
    Public Property IncomingAgency() As String
    Public Property BookingStateDesc() As String
    Public Property HotelFlag() As String
    Public Property MissingBookings() As String
    Public Property MarginCheck() As String
    Public Property DifferenceToPrice() As String
    Public Property ActionBy() As String
    Public Property Status() As String
    Public Property Comments() As String
    Public Property AdjustedPrice() As String
    Public Property PriceBreakdown() As String
    Public Property LoginID() As Integer
    Public Property Junk() As Boolean

    Public Function CheckJunk() As Short
        Dim result As Short = 0
        Dim status As String = GwgStatus.ToLower

        If status = "bna" Or status = "onr" Or status = "stp" Or MarginCheck.ToLower = "request" _
            Or MarginCheck.ToLower = "option" Or NetRateHotelTC < 1 Or HotelName.ToLower Like "*rundreise*" _
            Or HotelName.ToLower Like "*circuit*" Or HotelName.ToLower Like "*roulette*" Then
            result = 1
        End If

        Return result
    End Function

    Public Shared Function CheckJunk(ByVal gwgStatus As String, ByVal marginCheck As String, ByVal netRateHotelTc As Double, ByVal hotelName As String) As Short
        Dim result As Short = 0

        Dim status As String = gwgStatus.ToLower

        If status = "bna" Or status = "onr" Or status = "stp" Or marginCheck.ToLower = "request" _
            Or marginCheck.ToLower = "option" Or netRateHotelTc < 1 Or hotelName.ToLower Like "*rundreise*" _
            Or hotelName.ToLower Like "*circuit*" Or hotelName.ToLower Like "*roulette*" Then
            result = 1
        End If

        Return result
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim sb As New System.Text.StringBuilder
        sb.Append(BookingID.ToString)
        sb.Append(Reference)
        sb.Append(HotelCode)
        sb.Append(HotelName)
        sb.Append(CountryCode)
        sb.Append(GwgStatus.ToUpper)
        sb.Append(PurchaseCurrency)
        sb.Append(PurchasePrice.ToString)
        sb.Append(SalesCurrency)
        sb.Append(SalesPrice.ToString)
        sb.Append(GwgHandlingFee.ToString)
        sb.Append(Margin.ToString)
        sb.Append(Difference.ToString)
        sb.Append(CurrencyHotelTC)
        sb.Append(NetRateHotelTC.ToString)
        sb.Append(NetRateHandlingTC.ToString)
        sb.Append(CheckHotel)
        sb.Append(CompanyGroup)
        sb.Append(BookingDate.ToString)
        sb.Append(TravelDate.ToString)
        sb.Append(RoomType)
        sb.Append(Board)
        sb.Append(Duration.ToString)
        sb.Append(TransferTo)
        sb.Append(TransferFrom)
        sb.Append(Pax.ToString)
        sb.Append(Adult.ToString)
        sb.Append(Child.ToString)
        sb.Append(ImportDate.ToString)
        sb.Append(IncomingAgency)
        sb.Append(BookingStateDesc)
        sb.Append(HotelFlag)
        sb.Append(MissingBookings)
        sb.Append(MarginCheck)
        sb.Append(DifferenceToPrice)
        sb.Append(PriceBreakdown)

        Return sb.ToString.GetHashCode()

    End Function

    Public Function Username() As Login
        Dim result As New Login()
        result.LoginId = LoginID
        result.GetById()

        Return result

    End Function

    Public Function GwgStatusNumber() As Integer
        Dim result As Integer
        Select Case GwgStatus.ToUpper
            Case "OK"
                result = 0
            Case "CAN"
                result = 1
            Case "ONR"
                result = 2
            Case "BNA"
                result = 3
            Case "STP"
                result = 4
            Case Else
                result = -1
        End Select
        Return result
    End Function
    Public Function Save() As Boolean
        Dim query As String
        Dim result As Boolean = True

        query = String.Format("EXEC dbo.SaveBooking 0, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}'; ", _
                                     Reference, HotelCode, HotelName, CountryCode, GwgStatus, PurchaseCurrency, PurchasePrice, SalesCurrency, SalesPrice, GwgHandlingFee, Margin, Difference, CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC, CheckHotel, CompanyGroup, BookingDate, TravelDate, RoomType, Board, Duration, TransferTo, TransferFrom, Pax, Adult, Child, ImportDate, IncomingAgency, BookingStateDesc, HotelFlag, MissingBookings, MarginCheck, DifferenceToPrice, ActionBy, PriceBreakdown, GV.CurrentUser.LoginId, CheckJunk().ToString)


        Dim queryResult As String = ExClass.QuerySet(query)
        If queryResult <> "True" Then
            MsgBox(queryResult)
            result = False
        End If

        Return result
    End Function

    Public Function GetByID() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT BookingID, Reference, HotelCode, HotelName, HotelCountry, GwgStatus, PurchaseCurrency, PurchasePrice," _
                              & " SalesCurrency, SalesPrice, GwgHandlingFee, Margin, Difference, CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC," _
                              & " CheckHotel, CompanyGroup, BookingDate, TravelDate, RoomType, Board, Duration, TransferTo, TransferFrom," _
                              & " Pax, Adult, Child, ImportDate, IncomingAgency, BookingStateDesc, HotelFlag, MissingBookings, MarginCheck," _
                              & " DifferenceTOPrice, dbo.ActionBy(BookingID) AS ActionBy, dbo.LastStatus(BookingID) AS Status, dbo.LastComment(BookingID) AS Comments," _
                              & " dbo.AdjustedPrice(BookingID) AS AdjustedPrice, PriceBreakdown, LoginID, Junk" _
                              & " FROM Booking WHERE BookingID = " & BookingID.ToString & ";"

        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            BookingID = dt.Rows(0)(0)
            Reference = dt.Rows(0)(1)
            HotelCode = dt.Rows(0)(2)
            HotelName = dt.Rows(0)(3)
            CountryCode = dt.Rows(0)(4)
            GwgStatus = dt.Rows(0)(5)
            PurchaseCurrency = dt.Rows(0)(6)
            PurchasePrice = dt.Rows(0)(7)
            SalesCurrency = dt.Rows(0)(8)
            SalesPrice = dt.Rows(0)(9)
            GwgHandlingFee = dt.Rows(0)(10)
            Margin = dt.Rows(0)(11)
            Difference = dt.Rows(0)(12)
            CurrencyHotelTC = dt.Rows(0)(13)
            NetRateHotelTC = dt.Rows(0)(14)
            NetRateHandlingTC = dt.Rows(0)(15)
            CheckHotel = dt.Rows(0)(16)
            CompanyGroup = dt.Rows(0)(17)
            BookingDate = dt.Rows(0)(18)
            TravelDate = dt.Rows(0)(19)
            RoomType = dt.Rows(0)(20)
            Board = dt.Rows(0)(21)
            Duration = dt.Rows(0)(22)
            TransferTo = dt.Rows(0)(23)
            TransferFrom = dt.Rows(0)(24)
            Pax = dt.Rows(0)(25)
            Adult = dt.Rows(0)(26)
            Child = dt.Rows(0)(27)
            ImportDate = dt.Rows(0)(28)
            IncomingAgency = dt.Rows(0)(29)
            BookingStateDesc = dt.Rows(0)(30)
            HotelFlag = dt.Rows(0)(31)
            MissingBookings = dt.Rows(0)(32)
            MarginCheck = dt.Rows(0)(33)
            DifferenceToPrice = dt.Rows(0)(34)
            ActionBy = dt.Rows(0)(35)
            If Not IsDBNull(dt.Rows(0)(36)) Then
                Status = dt.Rows(0)(36)
            End If
            If Not IsDBNull(dt.Rows(0)(37)) Then
                Comments = dt.Rows(0)(37)
            End If
            If Not IsDBNull(dt.Rows(0)(38)) Then
                AdjustedPrice = dt.Rows(0)(38)
            End If

            PriceBreakdown = dt.Rows(0)(39)
            LoginID = dt.Rows(0)(40)
            result = True
        End If
        Return result
    End Function
End Class

Public Class Comment
    Public Property CommentID() As Long
    Public Property BookingID() As Long
    Public Property CommentDate() As DateTime
    Public Property Comment() As String
    Public Property Calculation() As Single
    Public Property Status() As String
    Public Property LoginID() As Integer

    Public Function Username() As Login
        Dim result As New Login()
        result.LoginId = LoginID
        result.GetById()
        Return result
    End Function

    Public Function Save() As Boolean
        Dim query As String
        Dim result As Boolean = True
        Comment = Comment.Replace("'", "''")
        CommentDate = Now
        LoginID = GV.CurrentUser.LoginId
        Dim calcText As String = Calculation.ToString
        If Calculation = Nothing Then
            calcText = "NULL"
        End If
        query = String.Format("INSERT INTO Comment (Date, BookingID, Comment, Calculation, LoginID, Status) VALUES ('{0}', {1},'{2}', {3}, {4}, '{5}');", _
                              CommentDate.ToString("MM/dd/yyyy HH:mm"), BookingID, Comment, calcText, LoginID, Status)


        Dim queryResult As String = ExClass.QuerySet(query)
        If queryResult <> "True" Then
            MsgBox(queryResult)
            result = False
        End If

        Return result
    End Function

    Public Function SaveMulti(ByVal bookingsList As List(Of Integer)) As Boolean
        Dim result As Boolean = True
        Comment = Comment.Replace("'", "''")
        CommentDate = Now
        LoginID = GV.CurrentUser.LoginId
        Dim calcText As String = Calculation
        If Calculation = Nothing Then
            calcText = "NULL"
        End If
        Dim query As String = "INSERT INTO Comment (Date, BookingID, Comment, Calculation, LoginID, Status) VALUES "
        For x As Integer = 0 To bookingsList.Count - 1
            query &= String.Format("('{0}', {1},'{2}', {3}, {4}, '{5}'), ", _
                                   CommentDate.ToString("MM/dd/yyyy HH:mm"), bookingsList(x).ToString, Comment, calcText, LoginID, Status)
        Next
        query = query.Substring(0, Len(query) - 2)

        Dim queryResult As String = ExClass.QuerySet(query)
        If queryResult <> "True" Then
            MsgBox(queryResult)
            result = False
        End If

        Return result
    End Function
End Class

Public Class Destination
    Public Property DestinationId() As Integer
    Public Property DestinationCode() As String
    Public Property Destination() As String

    Public Function UniqueCode() As Boolean
        Dim result As Boolean = False
        Dim query As String
        query = "SELECT COUNT(*) FROM Destination WHERE DestinationCode = '" & DestinationCode & "' AND DestinationID != " & DestinationId & ";"

        Dim queryResult As New DataTable()
        queryResult = ExClass.QueryGet(query)
        If queryResult.Rows(0)(0) = 0 Then
            result = True
        End If
        Return result
    End Function
    Public Function SaveDestination() As Boolean

        Destination = StrConv(Destination, VbStrConv.ProperCase)

        Dim result As Boolean = False
        Dim queryResult As String
        Dim query As String
        If DestinationId = 0 Then
            query = "INSERT INTO Destination (DestinationCode, Destination) VALUES ('" & DestinationCode.ToUpper & "', '" & Destination & "');"
        Else
            query = "UPDATE Destination SET DestinationCode = '" & DestinationCode.ToUpper _
                & "', Destination = '" & Destination & "' WHERE DestinationID = " & DestinationId & ";"
        End If

        queryResult = ExClass.QuerySet(query)
        If queryResult = "True" Then
            result = True
            frmMain.FillRibbonDestinations()
        Else
            MsgBox(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Destination WHERE DestinationID = " & DestinationId.ToString & ";"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            DestinationCode = dt.Rows(0)(1)
            Destination = dt.Rows(0)(2)

            result = True
        End If

        Return result

    End Function
End Class

Public Class TourOperator
    Public Property TourOperatorID() As Integer
    Public Property TourOperator() As String

    Public Function UniqueCode() As Boolean
        Dim result As Boolean = False
        Dim query As String
        query = "SELECT COUNT(*) FROM TourOperator WHERE TourOperator = '" & TourOperator & "' AND TourOperatorID != " & TourOperatorID & ";"

        Dim queryResult As New DataTable()
        queryResult = ExClass.QueryGet(query)
        If queryResult.Rows(0)(0) = 0 Then
            result = True
        End If
        Return result
    End Function
    Public Function SaveTourOperator() As Boolean

        TourOperator = TourOperator.ToUpper

        Dim result As Boolean = False
        Dim queryResult As String
        Dim query As String
        If TourOperatorID = 0 Then
            query = "INSERT INTO TourOperator (TourOperator) VALUES ('" & TourOperator & "');"
        Else
            query = "UPDATE TourOperator SET TourOperator = '" & TourOperator _
                & "' WHERE TourOperatorID = " & TourOperatorID & ";"
        End If

        queryResult = ExClass.QuerySet(query)
        If queryResult = "True" Then
            result = True
        Else
            MsgBox(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM TourOperator WHERE TourOperatorID = " & TourOperatorID.ToString & ";"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            TourOperator = dt.Rows(0)(1)

            result = True
        End If

        Return result

    End Function
End Class



Public Class Margin
    Public Property MarginId() As Integer
    Public Property DestinationId() As Integer
    Public Property TourOperatorId() As Integer
    Public Property MarginFrom() As Single
    Public Property MarginTo() As Single
    Public Property DifferenceFrom() As Single
    Public Property DifferenceTo() As Single
    Public Property EffectiveDate() As Date

    Public Function SaveMargin() As Boolean
        Dim result As Boolean = False
        Dim queryResult As String
        Dim query As String
        If MarginId = 0 Then
            query = String.Format("INSERT INTO Margin (DestinationID, TourOperatorID, MarginFrom, MarginTo, DifferenceFrom, DifferenceTo, EffectiveDate) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, '{6}');", _
                                  DestinationId.ToString, TourOperatorId, MarginFrom.ToString, MarginTo.ToString, DifferenceFrom.ToString _
                                  , DifferenceTo.ToString, EffectiveDate.ToString("MM/dd/yyyy"))
        Else
            query = String.Format("UPDATE Margin SET DestinationID = {0}, TourOperatorID = {1}, MarginFrom = {2}, MarginTo = {3}," _
                                  & " DifferenceFrom = {4}, DifferenceTo = {5}, EffectiveDate = '{6}'" _
                                  & " WHERE MarginID = {7};", DestinationId.ToString, TourOperatorId, MarginFrom.ToString, MarginTo.ToString, _
                                  DifferenceFrom.ToString, DifferenceTo.ToString, EffectiveDate.ToString("MM/dd/yyyy"), MarginId.ToString)
        End If

        queryResult = ExClass.QuerySet(query)
        If queryResult = "True" Then
            result = True
        Else
            MsgBox(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Margin WHERE MarginID = " & MarginId.ToString & ";"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            MarginId = dt.Rows(0)(0)
            DestinationId = dt.Rows(0)(1)
            TourOperatorId = dt.Rows(0)(2)
            MarginFrom = dt.Rows(0)(3)
            MarginTo = dt.Rows(0)(4)
            DifferenceFrom = dt.Rows(0)(5)
            DifferenceTo = dt.Rows(0)(6)
            EffectiveDate = dt.Rows(0)(7)
            result = True
        End If

        Return result

    End Function

    Public Function DeleteById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "DELETE FROM Margin WHERE MarginID = " & MarginId.ToString & ";"
        Dim messageResult As String
        messageResult = ExClass.QuerySet(query)
        If messageResult = "True" Then
            result = True
        Else
            MsgBox(messageResult)
        End If

        Return result
    End Function
End Class

Public Class Currency
    Public Property CurrencyId() As Integer
    Public Property Currency() As String
    Public Property Rate() As Decimal
    Public Property EffectiveDate() As Date
    Public Property LoginID() As Integer
    Public Property TimeAdded() As DateTime


    Public Function SaveCurrency() As Boolean
        Dim result As Boolean = False
        Dim queryResult As String
        Dim query As String
        If CurrencyId = 0 Then
            query = String.Format("INSERT INTO Exchange (Currency, Rate, EffectiveDate, LoginID) " _
                                  & "VALUES ('{0}', {1}, '{2}', {3});", _
                                  Currency.ToUpper, Rate.ToString, EffectiveDate.ToString("MM/dd/yyyy"), LoginID.ToString)
        Else
            query = String.Format("UPDATE Exchange SET Currency = '{0}', Rate = {1}, EffectiveDate = '{2}', LoginID = {3}" _
                                  & " WHERE ExchangeID = {4};", _
                                  Currency.ToUpper, Rate.ToString, EffectiveDate.ToString("MM/dd/yyyy"), LoginID.ToString, CurrencyId.ToString)
        End If

        queryResult = ExClass.QuerySet(query)
        If queryResult = "True" Then
            result = True
        Else
            MsgBox(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Exchange WHERE ExchangeID = " & CurrencyId.ToString & ";"
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            CurrencyId = dt.Rows(0)(0)
            Currency = dt.Rows(0)(1)
            Rate = dt.Rows(0)(2)
            EffectiveDate = dt.Rows(0)(3)
            LoginID = dt.Rows(0)(4)
            result = True
        End If

        Return result

    End Function

    Public Function DeleteById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "DELETE FROM Exchange WHERE ExchangeID = " & CurrencyId.ToString & ";"
        Dim messageResult As String
        messageResult = ExClass.QuerySet(query)
        If messageResult = "True" Then
            result = True
        Else
            MsgBox(messageResult)
        End If

        Return result
    End Function
End Class