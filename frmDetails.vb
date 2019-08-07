Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors

Partial Public Class frmDetails

    Public Sub New()
        InitializeComponent()

        dataLayoutControl1.DataSource = GetDataSource()
        dataLayoutControl1.RetrieveFields()

        Dim flatList As List(Of BaseLayoutItem) = (New FlatItemsList()).GetItemsList(dataLayoutControl1.Root)
        'Dim aboutItem As BaseLayoutItem = flatList.First(Function(e) e.Text = "About")
        'aboutItem.TextLocation = DevExpress.Utils.Locations.Top
    End Sub
    Private Shared Function GetDataSource() As List(Of Booking)
        Dim result As New List(Of Booking)()
        Dim booking As New Booking()

        With booking
            .ID = 11348
            .ReferenceNo = "8B79V"
            .Code = "VRA344"
            .Hotel = "Belive Exp. Las Morl"
            .Country = "CU"
            .GStatus = "Ok"
            .PCurrency = "USD"
            .PPrice = 756.0
            .SCurrency = "USD"
            .SPrice = 769.5
            .GWGHandling = 0.0
            .MarginValue = 1.75
            .DifferenceVAlue = 0.0
            .CurrencyTC = "USD"
            .NetRateHotel = 769.5
            .NetRateHandling = 0.02
            .Check = "E"
            .CGroup = "5vF"
            .BDate = #4/13/2019#
            .TDAte = #5/11/2019#
            .Room = "DZ"
            .BoardPlan = "I"
            .DurationValue = 9
            .TTo = "T"
            .TFrom = "T"
            .PaxValue = 2
            .AdultValue = 2
            .ChildValue = 0
            .IDate = #4/15/2019#
            .Agency = "MEETING POINT CUBA"
            .BookingStatus = "Festbuchung"
            .Breakdown = "http://gwg.meeting-point.com/SupportTools/gwgpricebreakdown/home.aspx?Destination=CU&Voucher=8B79V&Hotel=VRA344"


        End With

        result.Add(booking)
        Return result
    End Function
   
    Public Enum Gender
        Male
        Female
    End Enum

    Public Class Booking

        Private Const RootGroup As String = "<Root>"
        Private Const FirstGroup As String = RootGroup & "/" & "{tabs}"
        Private Const Reference As String = FirstGroup & "/" & "<Reference->"
        Private Const HotelCode As String = Reference & "/" & "<HotelCode->"
        Private Const HotelName As String = HotelCode & "/" & "<HotelName->"
        Private Const HotelCountry As String = HotelName & "/" & "<HotelCountry->"
        Private Const GWGStatus As String = HotelCountry & "/" & "<GWGStatus->"
        Private Const PurchaseCurrency As String = GWGStatus & "/" & "<PurchaseCurrency->"
        Private Const PurchasePrice As String = PurchaseCurrency & "/" & "<PurchasePrice->"
        Private Const SalesCurrency As String = PurchasePrice & "/" & "<SalesCurrency->"
        Private Const SalesPrice As String = SalesCurrency & "/" & "<SalesPrice->"
        Private Const GWGHandlingFee As String = SalesPrice & "/" & "<GWGHandlingFee->"
        Private Const Margin As String = GWGHandlingFee & "/" & "<Margin->"
        Private Const Difference As String = Margin & "/" & "<Difference->"
        Private Const CurrencyHotelTC As String = Difference & "/" & "<CurrencyHotelTC->"
        Private Const NetRateHandlingTC As String = CurrencyHotelTC & "/" & "<NetRateHandlingTC->"
        Private Const CheckedHotel As String = NetRateHandlingTC & "/" & "<CheckedHotel->"
        Private Const Company_Group As String = CheckedHotel & "/" & "<Company_Group->"
        Private Const Bookingdate As String = Company_Group & "/" & "<Bookingdate->"
        Private Const Traveldate As String = Bookingdate & "/" & "<Traveldate->"
        Private Const Roomtype As String = Traveldate & "/" & "<Roomtype->"
        Private Const Board As String = Roomtype & "/" & "<Board->"
        Private Const Duration As String = Board & "/" & "<Duration->"
        Private Const TransferTo As String = Duration & "/" & "<TransferTo->"
        Private Const TransferFrom As String = TransferTo & "/" & "<TransferFrom->"
        Private Const Pax As String = TransferFrom & "/" & "<Pax->"
        Private Const Adult As String = Pax & "/" & "<Adult->"
        Private Const Child As String = Adult & "/" & "<Child->"
        Private Const ImportDate As String = Child & "/" & "<ImportDate->"
        Private Const IncomingAgency As String = ImportDate & "/" & "<IncomingAgency->"
        Private Const BookingStateDesc As String = IncomingAgency & "/" & "<BookingStateDesc->"
        Private Const HotelFlag As String = BookingStateDesc & "/" & "<HotelFlag->"
        Private Const MissingBookings As String = HotelFlag & "/" & "<MissingBookings->"
        Private Const MarginCheck As String = MissingBookings & "/" & "<MarginCheck->"
        Private Const DifferenceToPrice As String = MarginCheck & "/" & "<DifferenceToPrice->"
        Private Const ActionBy As String = DifferenceToPrice & "/" & "<ActionBy->"
        Private Const Status As String = ActionBy & "/" & "<Status->"
        Private Const Comments As String = Status & "/" & "<Comments->"
        Private Const DifferenceReason As String = Comments & "/" & "<DifferenceReason->"
        Private Const PriceBreakdown As String = DifferenceReason & "/" & "<PriceBreakdown->"

        'Private Const RootGroup As String = "<Root>"
        'Private Const Photo As String = RootGroup & "/" & "<Photo->"
        'Private Const FirstNameAndLastName As String = Photo & "/" & "<FirstAndLastName>"
        'Private Const TabbedGroup As String = FirstNameAndLastName & "/" & "{Tabs}"
        'Private Const ContactGroup As String = TabbedGroup & "/" & "Contact"
        'Private Const BDateAndGender As String = ContactGroup & "/" & "<BDateAndGender->"
        'Private Const HomeAddressAndPhone As String = ContactGroup & "/" & "<HomeAddressAndPhone->"
        'Private Const JobGroup As String = TabbedGroup & "/" & "Job"
        'Private Const HDateAndSalary As String = JobGroup & "/" & "<HDateAndSalary->"
        'Private Const EmailAndSkype As String = JobGroup & "/" & "<EmailAndSkype->"
        'Private Const GroupAndTitle As String = JobGroup & "/" & "<GroupAndTitle->"

        <Key, Display(AutoGenerateField:=False)>
        Public Property ID() As Integer
        <Display(Name:="", GroupName:=FirstGroup, Order:=0)>
        Public Property ReferenceNo() As String
        <Display(Name:="Reference", GroupName:=FirstGroup, Order:=1)>
        Public Property Code() As String
        <Display(Name:="HotelCode", GroupName:=FirstGroup, Order:=2)>
        Public Property Hotel() As String
        <Display(Name:="HotelName", GroupName:=FirstGroup, Order:=3)>
        Public Property Country() As String
        <Display(Name:="CountryCode", GroupName:=FirstGroup, Order:=4)>
        Public Property GStatus() As String
        <Display(Name:="GWG_Status", GroupName:=FirstGroup, Order:=5)>
        Public Property PCurrency() As String
        <Display(Name:="PurchaseCurrency", GroupName:=FirstGroup, Order:=6)>
        Public Property PPrice() As Double
        <Display(Name:="PurchasePrice", GroupName:=FirstGroup)>
        Public Property SCurrency() As String
        <Display(Name:="SalesCurrency", GroupName:=FirstGroup)>
        Public Property SPrice() As Double
        <Display(Name:="SalesPrice", GroupName:=FirstGroup)>
        Public Property GWGHandling() As Double
        <Display(Name:="GWGHandlingFee", GroupName:=FirstGroup, Order:=6)>
        Public Property MarginValue() As Double
        <Display(Name:="Margin", GroupName:=FirstGroup, Order:=4)>
        Public Property DifferenceVAlue() As Double
        <Display(Name:="Difference", GroupName:=FirstGroup)>
        Public Property CurrencyTC() As String
        <Display(Name:="CurrencyHotelTC", GroupName:=FirstGroup)>
        Public Property NetRateHotel() As Double
        <Display(Name:="NetRateHotelTC", GroupName:=FirstGroup)>
        Public Property NetRateHandling() As Double
        <Display(Name:="NetRateHandlingTC", GroupName:=FirstGroup)>
        Public Property CHotel() As String
        <Display(Name:="CheckHotel", GroupName:=FirstGroup)>
        Public Property CGroup() As String
        <Display(Name:="Company_Group", GroupName:=FirstGroup)>
        Public Property BDate() As Date
        <Display(Name:="Bookingdate", GroupName:=FirstGroup)>
        Public Property TDAte() As Date
        <Display(Name:="TravelDate", GroupName:=FirstGroup)>
        Public Property Room() As String
        <Display(Name:="Roomtype", GroupName:=FirstGroup)>
        Public Property BoardPlan() As String
        <Display(Name:="Board", GroupName:=FirstGroup)>
        Public Property DurationValue() As Integer
        <Display(Name:="Duration", GroupName:=FirstGroup)>
        Public Property TTo() As String
        <Display(Name:="TransferTo", GroupName:=FirstGroup)>
        Public Property TFrom() As String
        <Display(Name:="TransferFrom", GroupName:=FirstGroup)>
        Public Property PaxValue() As Short
        <Display(Name:="Pax", GroupName:=FirstGroup)>
        Public Property AdultValue() As Short
        <Display(Name:="Adult", GroupName:=FirstGroup)>
        Public Property ChildValue() As Short
        <Display(Name:="Child", GroupName:=FirstGroup)>
        Public Property IDate() As Date
        <Display(Name:="ImportDate", GroupName:=FirstGroup)>
        Public Property Agency() As String
        <Display(Name:="IncomingAgency", GroupName:=FirstGroup)>
        Public Property StateDesc() As String
        <Display(Name:="BookingStateDesc", GroupName:=FirstGroup)>
        Public Property Flag() As String
        <Display(Name:="HotelFlag", GroupName:=FirstGroup)>
        Public Property Missing() As String
        <Display(Name:="MissingBookings", GroupName:=FirstGroup)>
        Public Property Check() As String
        <Display(Name:="MarginCheck", GroupName:=FirstGroup)>
        Public Property DifferencePrice() As String
        <Display(Name:="DifferenceToPrice", GroupName:=FirstGroup)>
        Public Property Action() As String
        <Display(Name:="ActionBy", GroupName:=FirstGroup)>
        Public Property BookingStatus() As String
        <Display(Name:="Status", GroupName:=FirstGroup)>
        Public Property BookingComments() As String
        <Display(Name:="Comments", GroupName:=FirstGroup), DataType(DataType.MultilineText)>
        Public Property Reason() As String
        <Display(Name:="DifferenceReason", GroupName:=FirstGroup)>
        Public Property Breakdown() As String
        <Display(Name:="PriceBreakdown", GroupName:=FirstGroup)>
        Public Property Saved() As Boolean

    End Class

End Class
