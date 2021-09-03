Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010

Partial Public Class FrmEdit
    Public Shared BookingId As Long
    Dim currentBooking As New Booking()
    Public Shared BookingsList As New List(Of Integer)
    Public Shared NoSave As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Function GetDataSource(ByVal bookingId As Long) As Booking
        Dim result As New Booking With {
            .BookingID = bookingId
        }
        result.GetByID()
        Return result
    End Function

    Private Sub PopulateStatusMain()
        ' Load status rows
        Dim dt As New DataTable()
        dt.Columns.Add("ID")
        dt.Columns.Add("Status")
        dt.Rows.Add({"PENDING DMC", "PENDING DMC"})
        If GV.CurrentUser.Authority <> "TO" AndAlso GV.CurrentUser.Authority <> "SU TO" Then
            dt.Rows.Add({"FIXED DMC", "FIXED DMC"})
            dt.Rows.Add({"CANNOT FIX", "CANNOT FIX"})
        End If
        dt.Rows.Add({"PENDING T/O", "PENDING T/O"})
        If GV.CurrentUser.Authority <> "DMC" AndAlso GV.CurrentUser.Authority <> "RS" AndAlso GV.CurrentUser.Authority <> "SU DMC" Then
            dt.Rows.Add({"FIXED T/O", "FIXED T/O"})
        End If
        LuStatus.Properties.DataSource = Nothing
        LuStatus.Properties.DataSource = dt
        LuStatus.Properties.ValueMember = "ID"
        LuStatus.Properties.DisplayMember = "Status"

    End Sub

    Private Sub UpdateBooking()

        With currentBooking
            .HotelCode = CStr(TxtHotelCode.EditValue)
            .HotelName = CStr(TxtHotelName.EditValue)
            .CountryCode = CStr(TxtCountry.EditValue)
            .GwgStatus = CbGWGStatus.Properties.GetDisplayText(CbGWGStatus.SelectedIndex)
            .BookingStatus = CbBookingStatus.Properties.GetDisplayText(CbBookingStatus.SelectedIndex)
            .PurchaseCurrency = CStr(TxtPurchaseCurrency.EditValue)
            .PurchasePrice = CDbl(TxtPurchasePrice.EditValue)
            .SalesCurrency = CStr(TxtSalesCurrency.EditValue)
            .SalesPrice = CDbl(TxtSalesPrice.EditValue)
            .GwgHandlingFee = CDbl(TxtHandlingFee.EditValue)
            .Margin = CDbl(TxtMargin.EditValue)
            .Difference = CDbl(TxtDifference.EditValue)
            .CurrencyHotelTC = CStr(TxtCurrencyHotelTc.EditValue)
            .NetRateHotelTC = CDbl(TxtNetRateHotelTc.EditValue)
            .NetRateHandlingTC = CDbl(TxtNetRateHandlingTc.EditValue)
            .CheckHotel = CStr(txtHotelCheck.EditValue)
            .CompanyGroup = CStr(TxtCompanyGroup.EditValue)
            .BookingDate = CDate(DeBookingDate.EditValue)
            .TravelDate = CDate(DeTravelDate.EditValue)
            .RoomType = CStr(TxtRoomType.EditValue)
            .Board = CStr(TxtBaord.EditValue)
            .Duration = CInt(TxtDuration.EditValue)
            .TransferTo = CStr(TxtTransferTo.EditValue)
            .TransferFrom = CStr(TxtTransferFrom.EditValue)
            .Pax = CShort(TxtPax.EditValue)
            .Adult = CShort(TxtAdult.EditValue)
            .Child = CShort(TxtChild.EditValue)
            .ImportDate = CDate(DeImportDate.EditValue)
            .MPImportDate = CDate(DeMPImportDate.EditValue)
            .IncomingAgency = CStr(TxtIncomingAgency.EditValue)
            .BookingStateDesc = CStr(TxtBookingStateDesc.EditValue)
            .PriceBreakdown = CStr(TxtPriceBreakdown.EditValue)
        End With

    End Sub

    Private Sub FrmEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If BookingsList.Count = 0 Then
            SelectedCurrentRow()
        End If

    End Sub

    Private Sub ShowBooking()

        With currentBooking
            labelControl.Text = String.Format("Booking# <b><color=0, 0, 255>{0}</color></b>", .Reference)
            TxtHotelCode.EditValue = .HotelCode
            TxtHotelName.EditValue = .HotelName
            TxtCountry.EditValue = .CountryCode
            CbGWGStatus.SelectedIndex = .GwgStatusNumber()
            CbBookingStatus.SelectedIndex = .BookingStatusNumber()
            TxtPurchaseCurrency.EditValue = .PurchaseCurrency
            TxtPurchasePrice.EditValue = .PurchasePrice
            TxtSalesCurrency.EditValue = .SalesCurrency
            TxtSalesPrice.EditValue = .SalesPrice
            TxtHandlingFee.EditValue = .GwgHandlingFee
            TxtMargin.EditValue = .Margin
            TxtDifference.EditValue = .Difference
            TxtCurrencyHotelTc.EditValue = .CurrencyHotelTC
            TxtNetRateHotelTc.EditValue = .NetRateHotelTC
            TxtNetRateHandlingTc.EditValue = .NetRateHandlingTC
            txtHotelCheck.EditValue = .CheckHotel
            TxtCompanyGroup.EditValue = .CompanyGroup
            DeBookingDate.EditValue = .BookingDate
            DeTravelDate.EditValue = .TravelDate
            TxtRoomType.EditValue = .RoomType
            TxtBaord.EditValue = .Board
            TxtDuration.EditValue = .Duration
            TxtTransferTo.EditValue = .TransferTo
            TxtTransferFrom.EditValue = .TransferFrom
            TxtPax.EditValue = .Pax
            TxtAdult.EditValue = .Adult
            TxtChild.EditValue = .Child
            DeImportDate.EditValue = .ImportDate
            TxtIncomingAgency.EditValue = .IncomingAgency
            TxtBookingStateDesc.EditValue = .BookingStateDesc
            TxtUser.EditValue = .Username().Username
            DeMPImportDate.EditValue = .MPImportDate
            TxtPriceBreakdown.EditValue = .PriceBreakdown
            TxtActionBy.EditValue = .LastUser.Username
            'show log data
            TxtPurchaseEUR.EditValue = .PurchaseEUR
            TxtSalesEUR.EditValue = .SalesEUR
            TxtMarginEUR.EditValue = .MarginEUR
            TxtNetRateEUR.EditValue = .NetRateEUR
            TxtDifferenceEUR.EditValue = .DifferenceEUR
            If .Junk Then TxtJunk.EditValue = "YES" Else TxtJunk.EditValue = "NO"
            If .Cancelled Then TxtCancelled.EditValue = "YES" Else TxtCancelled.EditValue = "NO"
            If .Excessive Then TxtExcessive.EditValue = "YES" Else TxtExcessive.EditValue = "NO"
            If .Mismatch Then TxtMismatching.EditValue = "YES" Else TxtMismatching.EditValue = "NO"
            TxtError.EditValue = .ErrorLog
            If .Negative Then TxtNegative.EditValue = "YES" Else TxtNegative.EditValue = "NO"

        End With

    End Sub
    Private Sub FrmEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If BookingsList.Count = 0 And BookingId <> 0 Then
            UpdateBooking()

            ' only check if user has the persmission to write the booking
            If GV.CurrentUser.Authority = "Admin" Or GV.CurrentUser.Authority = "RS" Then
                Dim tempBooking As Booking
                tempBooking = GetDataSource(BookingId)

                If currentBooking.GetHashCode <> tempBooking.GetHashCode Then
                    Dim diaResult As DialogResult
                    diaResult = XtraMessageBox.Show("Want to save changes to " & currentBooking.Reference & "?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If diaResult = DialogResult.Yes Then
                        If currentBooking.Save() Then
                            UpdateChangedRow()
                        End If
                    ElseIf diaResult = DialogResult.Cancel Then
                        e.Cancel = True
                    End If
                End If
            End If

        End If


        grpAddNewComment.Visibility = Utils.LayoutVisibility.Never
    End Sub

    Private Sub SelectedCurrentRow()
        Dim rowHandle As Integer = FrmMain.GridView1.LocateByValue("BookingID", currentBooking.BookingID)
        If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            FrmMain.GridView1.FocusedRowHandle = rowHandle
            FrmMain.GridView1.SelectRow(rowHandle)
        End If
    End Sub

    Private Sub UpdateChangedRow()
        Dim rowHandle As Integer = FrmMain.GridView1.LocateByValue("BookingID", currentBooking.BookingID)
        If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            FrmMain.UpdateCertainRow(rowHandle, currentBooking)
        End If
    End Sub

    Private Sub FrmEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S And TabbedControlGroup2.SelectedTabPageIndex = 0 Then
            SaveCurrent()
        ElseIf e.Control And e.KeyCode = Keys.S And TabbedControlGroup2.SelectedTabPageIndex = 2 _
            And grpAddNewComment.Visibility = Utils.LayoutVisibility.Always Then
            BtnSaveComment.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmMain.Wait(True)

        PopulateStatusMain()

        If BookingsList.Count = 0 Then
            currentBooking = GetDataSource(BookingId)
            ShowBooking()
            GetComments()
            LayoutControlGroup5.Visibility = Utils.LayoutVisibility.Always
            GridControl1.Visible = True
            If NoSave Then
                Me.Text = BookingId.ToString & " (READ-ONLY)"
                For Each i As WindowsUIButton In windowsUIButtonPanelMain.Buttons
                    If i.Caption = "Save" Then
                        i.Enabled = False
                        Exit For
                    End If
                Next
                BtnSaveComment.Enabled = False
            Else
                Me.Text = BookingId.ToString
                For Each i As WindowsUIButton In windowsUIButtonPanelMain.Buttons
                    If i.Caption = "Save" Then
                        i.Enabled = True
                        Exit For
                    End If
                Next
                BtnSaveComment.Enabled = True
            End If
        Else
            LayoutControlGroup5.Visibility = Utils.LayoutVisibility.Never
            GridControl1.Visible = False
            labelControl.Text = "Multiple Bookings"
            GridControl1.DataSource = Nothing
            If NoSave Then
                Me.Text = "Multi-Bookings (READ-ONLY)"
            Else
                Me.Text = "Multi-Bookings"
            End If
            For Each i As WindowsUIButton In windowsUIButtonPanelMain.Buttons
                If i.Caption = "Save" Then
                    i.Enabled = True
                    Exit For
                End If
            Next
            BtnSaveComment.Enabled = True
        End If

        FrmMain.Wait(False)
    End Sub

    Private Sub GetComments()
        Dim query As String = "SELECT * FROM Comment, Login WHERE Comment.LoginID = Login.LoginID AND" _
                              & " BookingID = " & currentBooking.BookingID.ToString _
                              & " ORDER BY Date DESC;"
        Dim dt As New DataTable()
        dt.Columns.Add("CommentID")
        dt.Columns.Add("BookingID")
        dt.Columns.Add("Date", GetType(DateTime))
        dt.Columns.Add("Comment")
        dt.Columns.Add("Calculation")
        dt.Columns.Add("Status", GetType(Integer))

        dt = CType(ExClass.QueryGet(query), DataTable)

        GridControl1.DataSource = dt

    End Sub

    Private Sub SaveCurrent()
        If Not NoSave And (GV.CurrentUser.Authority = "Admin" Or GV.CurrentUser.Authority = "RS") Then
            FrmMain.Wait(True)
            UpdateBooking()
            If currentBooking.Save() Then
                currentBooking = GetDataSource(BookingId)
                ShowBooking()
                UpdateChangedRow()
            End If
            FrmMain.Wait(False)
        End If
    End Sub
    Private Sub WindowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveCurrent()
        ElseIf e.Button.Properties.Caption = "Reset Changes" Then
            FrmMain.Wait(True)
            currentBooking = GetDataSource(BookingId)
            ShowBooking()
            FrmMain.Wait(False)
        ElseIf e.Button.Properties.Caption = "Close" Then
            Me.Close()
        ElseIf e.Button.Properties.Caption = "Mail" Then
            Dim subject, body As String


            subject = String.Format("Profitability Tool; Ref# {0} **{1}**",
                                    currentBooking.Reference, Today.ToString("dd.MM.yy"))
            body = String.Format("Dear {0}," & vbNewLine & vbNewLine & "Ref# {1}." & vbNewLine & "Please check this booking" _
                                 & vbNewLine & vbNewLine & "BR" & vbNewLine & "{2}",
                                 currentBooking.LastUser.Fullname,
                                 currentBooking.Reference, GV.CurrentUser.Fullname)

            SendMail.SetEmailSend(subject, body, currentBooking.LastUser.Mail, "")

        End If

    End Sub

    Private Sub BtnToggleComment_Click(sender As Object, e As EventArgs) Handles BtnToggleComment.Click
        If grpAddNewComment.Visibility = Utils.LayoutVisibility.Never Then
            grpAddNewComment.Visibility = Utils.LayoutVisibility.Always
            LuStatus.Focus()
        Else
            grpAddNewComment.Visibility = Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub BtnCancelComment_Click(sender As Object, e As EventArgs) Handles BtnCancelComment.Click
        grpAddNewComment.Visibility = Utils.LayoutVisibility.Never
        ClearComment()
    End Sub

    Private Sub ClearComment()
        LuStatus.EditValue = Nothing
        TxtComment.EditValue = ""
        TxtCalculation.EditValue = ""
    End Sub

    Private Sub BtnSaveComment_Click(sender As Object, e As EventArgs) Handles BtnSaveComment.Click
        If LuStatus.EditValue Is Nothing Then
            XtraMessageBox.Show("Please enter status!")
            LuStatus.Focus()
        ElseIf CStr(TxtComment.EditValue) = "" Then
            XtraMessageBox.Show("please enter comment!")
            TxtComment.Focus()
        Else
            FrmMain.Wait(True)
            Dim comment = New Comment With {
                .Status = CStr(LuStatus.EditValue),
                .Comment = CStr(TxtComment.EditValue),
                .BookingID = currentBooking.BookingID
            }
            If CStr(TxtCalculation.EditValue) = "" Then
                comment.Calculation = Nothing
            Else
                comment.Calculation = CSng(TxtCalculation.EditValue)
            End If

            If BookingsList.Count = 0 Then
                If comment.Save() Then
                    GetComments()
                    UpdateBookingStatus(False, comment.Status, GV.CurrentUser.LoginId, comment.Comment, comment.Calculation)
                    grpAddNewComment.Visibility = Utils.LayoutVisibility.Never

                    ClearComment()
                End If
            Else
                RemoveReadOnly()
                If BookingsList.Count > 0 Then
                    If comment.SaveMulti(BookingsList) Then
                        UpdateBookingStatus(True, comment.Status, GV.CurrentUser.LoginId, comment.Comment, comment.Calculation)
                        grpAddNewComment.Visibility = Utils.LayoutVisibility.Never

                        ClearComment()
                        Me.Close()
                    End If
                Else
                    FrmMain.Wait(False)
                    XtraMessageBox.Show("Cannot save comment. All bookings are locked!")
                    Exit Sub
                End If

            End If

            FrmMain.Wait(False)
        End If
    End Sub

    Private Sub UpdateBookingStatus(ByVal multiple As Boolean, ByVal status As String, ByVal actionBy As Integer, ByVal comment As String, ByVal adjustedPrice As Double)

        currentBooking.Status = status
        currentBooking.ActionBy = actionBy
        currentBooking.Comments = comment
        currentBooking.AdjustedPrice = CStr(adjustedPrice)
        If Not multiple Then
            FrmMain.UpdateCertainRow(FrmMain.GridView1.FocusedRowHandle, currentBooking)
        Else
            Dim withPrice As Boolean = adjustedPrice <> Nothing
            FrmMain.UpdateCertainRow(withPrice, currentBooking)

        End If
    End Sub
    Private Sub TxtComment_EditValueChanged(sender As Object, e As EventArgs) Handles TxtComment.EditValueChanged
        Dim textCalc As Single = ExClass.CalculateText(CStr(TxtComment.EditValue))
        If textCalc <> 0 Then
            TxtCalculation.Text = textCalc.ToString
        End If
    End Sub

    Private Sub RemoveReadOnly()
        ' Remove locked bookings from the list
        Dim unlockedBookings As String
        unlockedBookings = String.Join(", ", BookingsList.[Select](Function(i) i.ToString()).ToArray)
        Dim bookingsQuery As String = String.Format("
                    SELECT BookingID FROM Booking WHERE BookingID IN ({0}) AND (Locked IS NULL OR Locked = {1});",
                                                    unlockedBookings, GV.CurrentUser.LoginId.ToString)
        Dim dt As DataTable = ExClass.QueryGet(bookingsQuery)
        BookingsList = New List(Of Integer)
        For Each r As DataRow In dt.Rows
            BookingsList.Add(CInt(r(0)))
        Next
    End Sub

    Private Sub LuStatus_EditValueChanged(sender As Object, e As EventArgs) Handles LuStatus.EditValueChanged
        If LuStatus.EditValue Is Nothing Then
            LuSection.EditValue = Nothing
        Else
            Dim userType As String
            If GV.CurrentUser.Authority = "TO" OrElse GV.CurrentUser.Authority = "SU TO" Then
                userType = "TO"
            Else
                userType = "DMC"
            End If
            Dim query As String = $"SELECT SectionID AS ID, Section
                                   FROM Section
                                   WHERE [Status] = '{LuStatus.EditValue}' AND UserType = '{userType}'
                                   ORDER BY Section;"
            Dim dt As DataTable = ExClass.QueryGet(query)
            LuSection.Properties.DataSource = Nothing
            LuSection.Properties.DataSource = dt
            LuSection.Properties.ValueMember = "ID"
            LuSection.Properties.DisplayMember = "Section"
        End If
    End Sub
End Class
