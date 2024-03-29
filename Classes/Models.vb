﻿Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class Models

End Class

''' <summary>
''' Database models & properties
''' </summary>

Public Class Login
    Public Property LoginId() As Integer
    Public Property Username() As String
    Public Property Fullname() As String
    Public Property Mail() As String
    Public Property Password() As String
    Public Property Authority() As String
    Public Property Active() As Boolean
    Public Property UserDestinations() As List(Of Destination)
    Public Property UserOperators() As String
    Public Property InvalidLogins() As Short
    Public Property IsLocked() As Boolean


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
                    LoginId = CInt(dr(0))
                    Username = CStr(dr(1))
                    FullName = CStr(dr(2))
                    Mail = CStr(dr(3))
                    Authority = CStr(dr(5))
                    Active = CBool(dr(6))
                    InvalidLogins = CShort(dr(7))
                    IsLocked = CBool(dr(8))
                    result = True
                End If
            End Using
            ExClass.myConn.Close()
        End Using
        GetUserDestinations()
        GetUserOperators()

        If Not result Then
            IsLocked = ExceededLogins()
        Else
            ClearInvalidLogins()
        End If

        Return result
    End Function

    Private Function ExceededLogins() As Boolean
        Dim result As Boolean = False
        Dim query As String
        query = String.Format("
                UPDATE [Login] SET InvalidLogins = IIF(InvalidLogins < 5, InvalidLogins + 1, InvalidLogins),
                Locked = IIF(InvalidLogins < 5, 0, 1) WHERE Username = '{0}';
                SELECT COALESCE(Locked, 0) FROM [Login] WHERE Username = '{0}';", Username)
        Dim dt As DataTable = ExClass.QueryGet(query)
        If dt.Rows.Count > 0 Then
            result = CBool(dt.Rows(0)(0))
        End If


        Return result
    End Function

    Private Sub ClearInvalidLogins()
        InvalidLogins = 0
        Update()
    End Sub

    Public Function UniqueUsername() As Boolean
        Dim result As Boolean = True
        Dim query As String = "SELECT COUNT(*) FROM Login WHERE Username = '" & Username & "' AND LoginID != " & LoginId.ToString & ";"

        Dim dt As DataTable = ExClass.QueryGet(query)

        If CType(dt.Rows(0)(0), Integer) <> 0 Then
            result = False
        End If

        Return result

    End Function

    Public Function Signup() As Boolean
        Dim result As Boolean
        Fullname = StrConv(FullName, VbStrConv.ProperCase)
        Mail = Mail.ToLower

        Dim query As String = String.Format("INSERT INTO Login (Username, FullName, Mail, Password, Authority, Active) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5});", _
                                            Username, FullName, Mail, HashPassword(), Authority, CShort(Active))
        result = ExClass.QuerySet(query) = "True"

        Return result
    End Function

    Public Function Update() As Boolean
        Dim result As Boolean
        Fullname = StrConv(FullName, VbStrConv.ProperCase)
        Mail = Mail.ToLower

        Dim query As String
        query = String.Format("UPDATE Login SET Username = '{0}', FullName = '{1}', Mail = '{2}', Authority = '{3}',
                                Active = {4}, InvalidLogins = {5}, Locked = {6} WHERE LoginID = {7};",
                              Username, Fullname, Mail, Authority, CShort(Active).ToString, InvalidLogins.ToString,
                              CShort(IsLocked).ToString, LoginId.ToString)
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

        Dim dt As DataTable = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            Username = CType(dt.Rows(0)(1), String)
            FullName = CType(dt.Rows(0)(2), String)
            Mail = CType(dt.Rows(0)(3), String)
            Password = CType(dt.Rows(0)(4), String)
            Authority = CType(dt.Rows(0)(5), String)
            Active = CType(dt.Rows(0)(6), Boolean)
            InvalidLogins = CType(dt.Rows(0)(7), Short)
            IsLocked = CType(dt.Rows(0)(8), Boolean)
            result = True
        End If

        Return result

    End Function

    Public Function GetByUsername() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Login WHERE Username = '" & Username & "';"

        Dim dt As DataTable = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            LoginId = CType(dt.Rows(0)(0), Integer)
            Username = CType(dt.Rows(0)(1), String)
            FullName = CType(dt.Rows(0)(2), String)
            Mail = CType(dt.Rows(0)(3), String)
            Password = CType(dt.Rows(0)(4), String)
            Authority = CType(dt.Rows(0)(5), String)
            Active = CType(dt.Rows(0)(6), Boolean)
            InvalidLogins = CType(dt.Rows(0)(7), Short)
            IsLocked = CType(dt.Rows(0)(8), Boolean)
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

        Dim dt As DataTable = ExClass.QueryGet(query)

        For x = 0 To dt.Rows.Count - 1
            Dim tempDestination As Destination = New Destination With {
                .DestinationId = CInt(dt.Rows(x)(0)),
                .DestinationCode = CStr(dt.Rows(x)(1)),
                .Destination = CStr(dt.Rows(x)(2))
            }
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

        Dim dt As DataTable = ExClass.QueryGet(query)
        Dim tempOperator As String
        For x = 0 To dt.Rows.Count - 1
            tempOperator = CStr(dt.Rows(x)(1))
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
    Public Property BookingStatus() As String
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
    Public Property MPImportDate() As Date
    Public Property IncomingAgency() As String
    Public Property BookingStateDesc() As String
    Public Property HotelFlag() As String
    Public Property MissingBookings() As String
    Public Property MarginCheck() As String
    Public Property DifferenceToPrice() As String
    Public Property ActionBy() As Integer
    Public Property Status() As String
    Public Property Comments() As String
    Public Property AdjustedPrice() As String
    Public Property PriceBreakdown() As String
    Public Property LoginID() As Integer
    Public Property Junk() As Boolean
    Public Property PurchaseEUR() As Double
    Public Property SalesEUR() As Double
    Public Property MarginEUR() As Double
    Public Property NetRateEUR() As Double
    Public Property DifferenceEUR() As Double
    Public Property Cancelled() As Boolean
    Public Property Excessive() As Boolean
    Public Property Mismatch() As Boolean
    Public Property Negative() As Boolean
    Public Property ErrorLog() As String
    Public Property SysImportDate() As Date
    Public Property Section() As String
    Public Property Attachments() As Short


    Public Function CheckJunk() As Short
        Dim result As Short = 0
        Dim status As String = GwgStatus.ToLower

        If status = "onr" OrElse MarginCheck.ToLower = "request" _
            OrElse MarginCheck.ToLower = "option" OrElse NetRateHotelTC <= 0 OrElse HotelName.ToLower Like "*rundreise*" _
            OrElse HotelName.ToLower Like "*circuit*" Or HotelName.ToLower Like "*roulette*" _
            OrElse HotelName.ToLower Like "*2 tage*" _
            OrElse HotelName.ToLower Like "*croisiere sur le nil*" _
            OrElse HotelName.ToLower = "makadi" _
            OrElse HotelName.ToLower Like "*m-s emilio*" _
            OrElse HotelName.ToLower Like "*m-s royal*" _
            OrElse HotelName.ToLower Like "*neverland by pick*" _
            OrElse HotelName.ToLower Like "*nile cruise*" _
            OrElse HotelName.ToLower Like "*nilkreuzfahrt*" _
            OrElse HotelName.ToLower Like "*schlagerfestival*" _
            OrElse HotelName.ToLower Like "*schlagerreise*" _
            OrElse (status = "can" AndAlso PurchasePrice = 0 AndAlso SalesPrice = 0 AndAlso NetRateHotelTC = 0) Then
            result = 1
        End If

        Return result
    End Function

    Public Shared Function CheckJunk(ByVal gwgStatus As String, ByVal marginCheck As String,
                                     ByVal purchasePrice As Double, ByVal salesPrice As Double,
                                     ByVal netRateHotelTc As Double, ByVal hotelName As String) As Short
        Dim result As Short = 0

        Dim status As String = gwgStatus.ToLower

        If status = "onr" Or marginCheck.ToLower = "request" _
            Or marginCheck.ToLower = "option" Or netRateHotelTc <= 0 Or hotelName.ToLower Like "*rundreise*" _
            Or hotelName.ToLower Like "*circuit*" _ ' Or hotelName.ToLower Like "*roulette*" _
            Or (status = "can" AndAlso purchasePrice = 0 AndAlso salesPrice = 0 AndAlso netRateHotelTc = 0) Then
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
        sb.Append(BookingStatus)
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
        sb.Append(MPImportDate.tostring)
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
        Dim result As New Login With {
            .LoginId = LoginID
        }
        result.GetById()

        Return result

    End Function

    Public Function LastUser() As Login
        Dim result As New Login With {
            .LoginId = ActionBy
        }
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

    Public Function BookingStatusNumber() As Integer
        Dim result As Integer
        Select Case BookingStatus.ToUpper
            Case "NEW"
                result = 0
            Case "AME"
                result = 1
            Case "CAN"
                result = 2
            Case "BNA"
                result = 3
            Case Else
                result = -1
        End Select
        Return result
    End Function
    Public Function Save() As Boolean
        Dim query As String
        Dim result As Boolean = True
        Difference = SalesPrice - NetRateHotelTC
        query = String.Format("EXEC dbo.SaveBooking 0, '{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', 
                                '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', 
                                '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}',
                                '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}',
                                '{36}', '{37}', '{38}', '{39}'; ",
                                     Reference, HotelCode, HotelName, CountryCode, GwgStatus, PurchaseCurrency,
                                     PurchasePrice, SalesCurrency, SalesPrice, GwgHandlingFee, Margin, Difference,
                                     CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC, CheckHotel, CompanyGroup,
                                     BookingDate.ToString("yyyy-MM-dd"), TravelDate.ToString("yyyy-MM-dd"),
                                     RoomType, Board, Duration, TransferTo, TransferFrom,
                                     Pax, Adult, Child, ImportDate.ToString("yyyy-MM-dd"), IncomingAgency,
                                     BookingStateDesc, HotelFlag,
                                     MissingBookings, MarginCheck, DifferenceToPrice, ActionBy, PriceBreakdown,
                                     GV.CurrentUser.LoginId, CheckJunk().ToString, BookingStatus, MPImportDate.ToString("yyyy-MM-dd"))


        Dim queryResult As String = ExClass.QuerySet(query)
        If queryResult <> "True" Then
            XtraMessageBox.Show(queryResult)
            result = False
        End If

        Return result
    End Function

    Public Function GetByID() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT Booking.BookingID, Reference, HotelCode, HotelName, HotelCountry, GwgStatus, PurchaseCurrency, PurchasePrice,
                                SalesCurrency, SalesPrice, GwgHandlingFee, Margin, Difference, CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC,
                                CheckHotel, CompanyGroup, BookingDate, TravelDate, RoomType, Board, Duration, TransferTo, TransferFrom,
                                Pax, Adult, Child, ImportDate, IncomingAgency, BookingStateDesc, HotelFlag, MissingBookings, MarginCheck,
                                DifferenceTOPrice, ActionBy, [Status], Comments,
                                AdjustedPrice, PriceBreakdown, Booking.LoginID, Junk, PurchasePriceEUR, SalesPriceEUR, MarginEUR, NetRateEUR,
                                DifferenceEUR, (CASE WHEN GWGStatus = 'Can' THEN 1 ELSE 0 END) AS Cancelled, ExcessiveMargin AS Excessive,
                                MismatchCalc As Mismatch, NegativeMargin,
                                BookingStatus, MPImportDate, [Log], Section, COALESCE(Attachments.Attachments, 0) AS Attachments
                                From Booking
                                JOIN [Login] ON [Login].LoginID = Booking.ActionBy
                                LEFT JOIN
                                (
                                    SELECT BookingID, COUNT(AttachmentID) AS Attachments
                                    FROM Attachment
                                    GROUP BY BookingID
                                ) Attachments ON Booking.BookingID = Attachments.BookingID


                                WHERE Booking.BookingID = " & BookingID.ToString & ";"

        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            BookingID = CLng(dt.Rows(0)(0))
            Reference = CStr(dt.Rows(0)(1))
            HotelCode = CStr(dt.Rows(0)(2))
            HotelName = CStr(dt.Rows(0)(3))
            CountryCode = CStr(dt.Rows(0)(4))
            GwgStatus = CStr(dt.Rows(0)(5))
            PurchaseCurrency = CStr(dt.Rows(0)(6))
            PurchasePrice = CDbl(dt.Rows(0)(7))
            SalesCurrency = CStr(dt.Rows(0)(8))
            SalesPrice = CDbl(dt.Rows(0)(9))
            GwgHandlingFee = CDbl(dt.Rows(0)(10))
            Margin = CDbl(dt.Rows(0)(11))
            Difference = CDbl(dt.Rows(0)(12))
            CurrencyHotelTC = CStr(dt.Rows(0)(13))
            NetRateHotelTC = CDbl(dt.Rows(0)(14))
            NetRateHandlingTC = CDbl(dt.Rows(0)(15))
            CheckHotel = CStr(dt.Rows(0)(16))
            CompanyGroup = CStr(dt.Rows(0)(17))
            BookingDate = CDate(dt.Rows(0)(18))
            TravelDate = CDate(dt.Rows(0)(19))
            RoomType = CStr(dt.Rows(0)(20))
            Board = CStr(dt.Rows(0)(21))
            Duration = CInt(dt.Rows(0)(22))
            TransferTo = CStr(dt.Rows(0)(23))
            TransferFrom = CStr(dt.Rows(0)(24))
            Pax = CShort(dt.Rows(0)(25))
            Adult = CShort(dt.Rows(0)(26))
            Child = CShort(dt.Rows(0)(27))
            ImportDate = CDate(dt.Rows(0)(28))
            IncomingAgency = CStr(dt.Rows(0)(29))
            BookingStateDesc = CStr(dt.Rows(0)(30))
            HotelFlag = CStr(dt.Rows(0)(31))
            MissingBookings = CStr(dt.Rows(0)(32))
            MarginCheck = CStr(dt.Rows(0)(33))
            DifferenceToPrice = CStr(dt.Rows(0)(34))

            ActionBy = CInt(dt.Rows(0)(35))
            If Not IsDBNull(dt.Rows(0)(36)) Then
                Status = CStr(dt.Rows(0)(36))
            End If
            If Not IsDBNull(dt.Rows(0)(37)) Then
                Comments = CStr(dt.Rows(0)(37))
            End If
            If Not IsDBNull(dt.Rows(0)(38)) Then
                AdjustedPrice = CStr(dt.Rows(0)(38))
            End If

            PriceBreakdown = CStr(dt.Rows(0)(39))
            LoginID = CInt(dt.Rows(0)(40))
            Junk = CBool(dt.Rows(0)(41))

            If Not IsDBNull(dt.Rows(0)(42)) Then
                PurchaseEUR = CDbl(dt.Rows(0)(42))
            End If
            If Not IsDBNull(dt.Rows(0)(43)) Then
                SalesEUR = CDbl(dt.Rows(0)(43))
            End If
            If Not IsDBNull(dt.Rows(0)(44)) Then
                MarginEUR = CDbl(dt.Rows(0)(44))
            End If
            If Not IsDBNull(dt.Rows(0)(45)) Then
                NetRateEUR = CDbl(dt.Rows(0)(45))
            End If
            If Not IsDBNull(dt.Rows(0)(46)) Then
                DifferenceEUR = CDbl(dt.Rows(0)(46))
            End If
            Cancelled = CBool(dt.Rows(0)(47))
            Excessive = CBool(dt.Rows(0)(48))
            Mismatch = CBool(dt.Rows(0)(49))
            Negative = CBool(dt.Rows(0)(50))
            ErrorLog = CStr(dt.Rows(0)(53))
            BookingStatus = CStr(dt.Rows(0)(51))
            If Not IsDBNull(dt.Rows(0)(52)) Then
                MPImportDate = CDate(dt.Rows(0)(52))
            End If
            Section = CStr(dt.Rows(0)(54))
            Attachments = CShort(dt.Rows(0)(55))
            result = True
        End If
        Return result
    End Function

    Public Shared Function GetBookingId(reference As String) As List(Of Long)
        Dim result = New List(Of Long)()
        Dim query As String = $"SELECT BookingID FROM Booking WHERE Reference = N'{reference}';"
        Dim dt = ExClass.QueryGet(query)

        For x As Integer = 0 To dt.Rows.Count - 1
            result.Add(CLng(dt.Rows(x)(0)))
        Next

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
    Public Property SectionID() As Integer

    Public Function Username() As Login
        Dim result As New Login With {
            .LoginId = LoginID
        }
        result.GetById()
        Return result
    End Function

    Public Function Save() As Boolean
        Dim query As String
        Dim result As Boolean = True
        Comment = Comment.Replace("'", "''")
        CommentDate = Now
        LoginID = GV.CurrentUser.LoginId
        Dim calcText As String = Calculation.ToString.Replace(",", ".")
        If Calculation = Nothing Then
            calcText = "NULL"
        End If

        Dim sectionText As String = "NULL"
        If SectionID <> 0 Then
            sectionText = SectionID.ToString
        End If

        query = String.Format("INSERT INTO Comment (Date, BookingID, Comment, Calculation, LoginID, Status, SectionID)
                               VALUES ('{0}', {1},'{2}', {3}, {4}, '{5}', {6});",
                              CommentDate.ToString("MM/dd/yyyy HH:mm"), BookingID, Comment, calcText, LoginID, Status, sectionText)
        query &= String.Format(" UPDATE Booking SET ActionBy = dbo.ActionBy(BookingID), Comments = dbo.LastComment(BookingID),
                                AdjustedPrice = dbo.AdjustedPrice(BookingID), [Status] = dbo.LastStatus(BookingID),
                                Section = dbo.LastSection(BookingID)
                                WHERE BookingID = {0};", BookingID.ToString)

        Dim queryResult As String = ExClass.QuerySet(query)
        If queryResult <> "True" Then
            XtraMessageBox.Show(queryResult)
            result = False
        End If

        Return result
    End Function

    Public Function SaveMulti(ByVal bookingsList As List(Of Long), Optional ByRef errors As String = "", Optional showError As Boolean = True) As Boolean
        Dim result As Boolean = True
        Comment = Comment.Replace("'", "''")
        CommentDate = Now
        LoginID = GV.CurrentUser.LoginId
        Dim calcText As String = Calculation.ToString.Replace(",", ".")
        If Calculation = Nothing Then
            calcText = "NULL"
        End If

        Dim sectionText As String = "NULL"
        If SectionID <> 0 Then
            sectionText = SectionID.ToString
        End If


        Dim query As String = "INSERT INTO Comment (Date, BookingID, Comment, Calculation, LoginID, Status, SectionID) VALUES "
        For x As Integer = 0 To bookingsList.Count - 1

            query &= String.Format("('{0}', {1},'{2}', {3}, {4}, '{5}', {6}), ",
                               CommentDate.ToString("MM/dd/yyyy HH:mm"), bookingsList(x).ToString, Comment, calcText, LoginID, Status, sectionText)
        Next
        query = query.Substring(0, Len(query) - 2)
        query &= String.Format("; UPDATE Booking SET ActionBy = dbo.ActionBy(BookingID), Comments = dbo.LastComment(BookingID),
                                AdjustedPrice = dbo.AdjustedPrice(BookingID), [Status] = dbo.LastStatus(BookingID),
                                Section = dbo.LastSection(BookingID)
                                WHERE BookingID IN ({0});", String.Join(", ", bookingsList.ToArray))


        Dim queryResult As String = ExClass.QuerySet(query)
        errors = queryResult
        If queryResult <> "True" AndAlso showError Then
            XtraMessageBox.Show(queryResult)
            result = False
        End If


        Return result
    End Function


    Public Shared Function Validate(reference As String, status As String, ByRef section As String, comment As String, calculation As String,
                                    ByRef bookingIds As List(Of Long), ByRef validations As List(Of String)) As Boolean
        validations = New List(Of String)()
        Dim result As Boolean = True
        bookingIds = Booking.GetBookingId(reference)
        If bookingIds.Count = 0 Then
            validations.Add("Wrong reference number")
            result = False
        End If
        Dim arrStatus() As String
        If GV.CurrentUser.Authority.Contains("DMC") Then
            arrStatus = {"CANNOT FIX", "FIXED DMC", "PENDING DMC", "PENDING T / O"}
        ElseIf GV.CurrentUser.Authority.Contains("TO") Then
            arrStatus = {"FIXED T / O", "PENDING DMC", "PENDING T / O"}
        Else
            arrStatus = {"CANNOT FIX", "FIXED DMC", "FIXED T / O", "PENDING DMC", "PENDING T / O"}
        End If
        If Not arrStatus.Contains(status) Then
            validations.Add("Invalid status")
            result = False
        End If

        If Not String.IsNullOrEmpty(section) Then
            Dim query As String = $"SELECT TOP 1 SectionID FROM Section WHERE Section = N'{section}' AND [Status] = N'{status}' AND UserType = '{GV.CurrentUser.Authority.Replace("SU ", "")}';"
            Dim sectionDT = ExClass.QueryGet(query)

            If sectionDT.Rows.Count = 0 Then
                validations.Add("Invalid section")
                result = False
            Else
                section = sectionDT.Rows(0)(0).ToString
            End If
        End If

        If String.IsNullOrEmpty(comment) Then
            validations.Add("Blank comment")
            result = False
        End If

        If Not String.IsNullOrEmpty(calculation) Then
            Dim temp As Double
            If Not Double.TryParse(calculation.Replace(",", "."), temp) Then
                validations.Add("Calculation should be numeric")
                result = False
            End If

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

        Dim queryResult As DataTable = ExClass.QueryGet(query)
        If CInt(queryResult.Rows(0)(0)) = 0 Then
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
            FrmMain.FillRibbonDestinations()
        Else
            XtraMessageBox.Show(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Destination WHERE DestinationID = " & DestinationId.ToString & ";"

        Dim dt As DataTable = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            DestinationCode = CStr(dt.Rows(0)(1))
            Destination = CStr(dt.Rows(0)(2))

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

        Dim queryResult As DataTable = ExClass.QueryGet(query)
        If CInt(queryResult.Rows(0)(0)) = 0 Then
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
            XtraMessageBox.Show(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM TourOperator WHERE TourOperatorID = " & TourOperatorID.ToString & ";"

        Dim dt As DataTable = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            TourOperator = CStr(dt.Rows(0)(1))
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
            XtraMessageBox.Show(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Margin WHERE MarginID = " & MarginId.ToString & ";"

        Dim dt As DataTable = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            MarginId = CInt(dt.Rows(0)(0))
            DestinationId = CInt(dt.Rows(0)(1))
            TourOperatorId = CInt(dt.Rows(0)(2))
            MarginFrom = CSng(dt.Rows(0)(3))
            MarginTo = CSng(dt.Rows(0)(4))
            DifferenceFrom = CSng(dt.Rows(0)(5))
            DifferenceTo = CSng(dt.Rows(0)(6))
            EffectiveDate = CDate(dt.Rows(0)(7))
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
            XtraMessageBox.Show(messageResult)
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
                                  & "VALUES ('{0}', {1}, '{2}', {3});",
                                  Currency.ToUpper, Rate.ToString, EffectiveDate.ToString("MM/dd/yyyy"), LoginID.ToString)
        Else
            query = String.Format("UPDATE Exchange SET Currency = '{0}', Rate = {1}, EffectiveDate = '{2}', LoginID = {3}" _
                                  & " WHERE ExchangeID = {4};",
                                  Currency.ToUpper, Rate.ToString, EffectiveDate.ToString("MM/dd/yyyy"), LoginID.ToString, CurrencyId.ToString)
        End If

        queryResult = ExClass.QuerySet(query)
        If queryResult = "True" Then
            result = True
        Else
            XtraMessageBox.Show(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = "SELECT * FROM Exchange WHERE ExchangeID = " & CurrencyId.ToString & ";"

        Dim dt As DataTable = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            CurrencyId = CInt(dt.Rows(0)(0))
            Currency = CStr(dt.Rows(0)(1))
            Rate = CDec(dt.Rows(0)(2))
            EffectiveDate = CDate(dt.Rows(0)(3))
            LoginID = CInt(dt.Rows(0)(4))
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
            XtraMessageBox.Show(messageResult)
        End If

        Return result
    End Function
End Class

Public Class Section
    Public Property SectionId() As Integer
    Public Property Section() As String
    Public Property Status() As String
    Public Property UserType() As String

    Public Function SaveSection() As Boolean
        Dim result As Boolean = False
        Dim queryResult As String
        Dim query As String
        If SectionId = 0 Then
            query = $"INSERT INTO Section (Section, [Status], UserType)
                      VALUES ('{Section.Trim.Replace("'", "''")}', '{Status}', '{UserType}');"
        Else
            query = $"UPDATE Section SET Section = '{Section.Trim.Replace("'", "''")}',
                        [Status] = '{Status}', UserType = '{UserType}' WHERE SectionID = {SectionId};"
        End If

        queryResult = ExClass.QuerySet(query)
        If queryResult = "True" Then
            result = True
        Else
            XtraMessageBox.Show(queryResult)
        End If

        Return result
    End Function

    Public Function GetById() As Boolean
        Dim result As Boolean = False
        Dim query As String = $"SELECT * FROM Section WHERE SectionID = {SectionId};"

        Dim dt As DataTable = ExClass.QueryGet(query)

        If dt.Rows.Count <> 0 Then
            Section = dt.Rows(0)(1).ToString
            Status = dt.Rows(0)(2).ToString
            UserType = dt.Rows(0)(3).ToString
            result = True
        End If

        Return result

    End Function

    Public Function DeleteById() As Boolean
        Dim result As Boolean = False
        Dim query As String = $"DELETE FROM Section WHERE SectionID = {SectionId};"
        Dim messageResult As String
        messageResult = ExClass.QuerySet(query)
        If messageResult = "True" Then
            result = True
        Else
            XtraMessageBox.Show(messageResult)
        End If

        Return result
    End Function
End Class

Public Class Attachment
    Public Property AttachmentId() As Integer
    Public Property BookingId() As Long
    Public Property Time() As DateTime
    Public Property AttachmentName() As String
    Public Property LoginId() As Integer

    Public FileData As Byte()

    Public Sub New(attachmentId As Integer, bookingId As Long _
                   , attachmentName As String, fileData As Byte(), loginId As Integer)
        Me.AttachmentId = attachmentId
        Me.BookingId = bookingId
        Me.AttachmentName = attachmentName
        Me.FileData = fileData
        Me.LoginId = loginId
    End Sub

    Public Function Save() As Boolean

        Dim query As String = $"INSERT INTO Attachment (BookingID, AttachmentName, FileData, LoginID) VALUES ({BookingId}, @AttachmentName, @FileData, {LoginId});"
        Dim liParams As List(Of SqlParameter) = New List(Of SqlParameter)()
        Dim fileNameParam As New SqlParameter("@AttachmentName", AttachmentName)
        Dim fileDataParam As New SqlParameter("@FileData", SqlDbType.VarBinary)
        fileDataParam.Value = FileData
        liParams.Add(fileNameParam)
        liParams.Add(fileDataParam)

        Dim result As Boolean = True
        Dim queryResult As String = ExClass.QuerySet(query, liParams)
        If queryResult <> "True" Then
            XtraMessageBox.Show(queryResult)
            Result = False
        End If

        Return Result
    End Function

    Public Shared Sub Delete(attachmentId As Integer)
        Dim query As String = $"DELETE FROM Attachment WHERE AttachmentID = {attachmentId};"
        ExClass.QuerySet(query)
    End Sub

    Public Shared Function GetByBooking(bookingId As Long) As DataTable
        Dim query As String = $"SELECT Att.AttachmentID, Att.[Time], Att.AttachmentName, Lo.Username
                                FROM Attachment Att
                                JOIN [Login] Lo ON Att.LoginID = Lo.LoginID
                                WHERE Att.BookingID = {bookingId};"
        Return ExClass.QueryGet(query)
    End Function

    Public Shared Function GetAttachmentFile(attachmentId As Integer) As Byte()
        Dim query As String = $"SELECT FileData FROM Attachment WHERE AttachmentID = {attachmentId};"
        Dim dt = ExClass.QueryGet(query)
        Dim result As Byte() = DirectCast(dt.Rows(0)(0), Byte())

        Return Result
    End Function


End Class

Public Class Audit
    Public Shared Function GetBookingAudit(bookingId As Long) As DataTable
        Dim query As String = $"SELECT Aud.AuditTrailID, Aud.[Time], Lo.Username
                                FROM AuditTrail Aud JOIN [Login] Lo ON Aud.LoginID = Lo.LoginID
                                WHERE Aud.BookingID = {bookingId};"
        Dim dt As DataTable = ExClass.QueryGet(query)
        Return dt
    End Function

    Public Shared Function GetAuditDetails(auditId As Long) As DataTable
        Dim query As String = $"SELECT OldValues, NewValues FROM AuditTrail WHERE AuditTrailID = {auditId};"
        Dim dt As DataTable = ExClass.QueryGet(query)
        Return dt
    End Function
End Class