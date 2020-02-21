Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Partial Public Class frmEdit
    Public Shared bookingId As Long
    Dim currentBooking As New Booking()
    Public Shared bookingsList As New List(Of Integer)
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Function GetDataSource(ByVal bookingId As Long) As Booking
        Dim result As New Booking()
        result.BookingID = bookingId
        result.GetByID()
        Return result
    End Function

    Private Sub PopulateStatusMain()
        'load status rows
        Dim dt As New DataTable()
        dt.Columns.Add("ID")
        dt.Columns.Add("Status")
        dt.Rows.Add({"PENDING DMC", "PENDING DMC"})
        If GV.CurrentUser.Authority <> "TO" Then
            dt.Rows.Add({"FIXED DMC", "FIXED DMC"})
        End If
        dt.Rows.Add({"PENDING T/O", "PENDING T/O"})
        If GV.CurrentUser.Authority <> "DMC" And GV.CurrentUser.Authority <> "RS" Then
            dt.Rows.Add({"FIXED T/O", "FIXED T/O"})
        End If
        luStatus.Properties.DataSource = Nothing
        luStatus.Properties.DataSource = dt
        luStatus.Properties.ValueMember = "ID"
        luStatus.Properties.DisplayMember = "Status"

    End Sub

    Private Sub UpdateBooking()
        With currentBooking
            .HotelCode = CStr(txtHotelCode.EditValue)
            .HotelName = CStr(txtHotelName.EditValue)
            .CountryCode = CStr(txtCountry.EditValue)
            .GwgStatus = cbGWGStatus.Properties.GetDisplayText(cbGWGStatus.SelectedIndex)

            .PurchaseCurrency = CStr(txtPurchaseCurrency.EditValue)
            .PurchasePrice = CDbl(txtPurchasePrice.EditValue)
            .SalesCurrency = CStr(txtSalesCurrency.EditValue)
            .SalesPrice = CDbl(txtSalesPrice.EditValue)
            .GwgHandlingFee = CDbl(txtHandlingFee.EditValue)
            .Margin = CDbl(txtMargin.EditValue)
            .Difference = CDbl(txtDifference.EditValue)
            .CurrencyHotelTC = CStr(txtCurrencyHotelTc.EditValue)
            .NetRateHotelTC = CDbl(txtNetRateHotelTc.EditValue)
            .NetRateHandlingTC = CDbl(txtNetRateHandlingTc.EditValue)
            .CheckHotel = CStr(txtHotelCheck.EditValue)
            .CompanyGroup = CStr(txtCompanyGroup.EditValue)
            .BookingDate = CDate(deBookingDate.EditValue)
            .TravelDate = CDate(deTravelDate.EditValue)
            .RoomType = CStr(txtRoomType.EditValue)
            .Board = CStr(txtBaord.EditValue)
            .Duration = CInt(txtDuration.EditValue)
            .TransferTo = CStr(txtTransferTo.EditValue)
            .TransferFrom = CStr(txtTransferFrom.EditValue)
            .Pax = CShort(txtPax.EditValue)
            .Adult = CShort(txtAdult.EditValue)
            .Child = CShort(txtChild.EditValue)
            .ImportDate = CDate(deImportDate.EditValue)
            .IncomingAgency = CStr(txtIncomingAgency.EditValue)
            .BookingStateDesc = CStr(txtBookingStateDesc.EditValue)

        End With

    End Sub

    Private Sub frmEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If bookingsList.Count = 0 Then
            SelectedCurrentRow()
        End If

    End Sub

    Private Sub ShowBooking()

        With currentBooking
            labelControl.Text = String.Format("Booking# <b><color=0, 0, 255>{0}</color></b>", .Reference)
            txtHotelCode.EditValue = .HotelCode
            txtHotelName.EditValue = .HotelName
            txtCountry.EditValue = .CountryCode
            cbGWGStatus.SelectedIndex = .GwgStatusNumber()
            txtPurchaseCurrency.EditValue = .PurchaseCurrency
            txtPurchasePrice.EditValue = .PurchasePrice
            txtSalesCurrency.EditValue = .SalesCurrency
            txtSalesPrice.EditValue = .SalesPrice
            txtHandlingFee.EditValue = .GwgHandlingFee
            txtMargin.EditValue = .Margin
            txtDifference.EditValue = .Difference
            txtCurrencyHotelTc.EditValue = .CurrencyHotelTC
            txtNetRateHotelTc.EditValue = .NetRateHotelTC
            txtNetRateHandlingTc.EditValue = .NetRateHandlingTC
            txtHotelCheck.EditValue = .CheckHotel
            txtCompanyGroup.EditValue = .CompanyGroup
            deBookingDate.EditValue = .BookingDate
            deTravelDate.EditValue = .TravelDate
            txtRoomType.EditValue = .RoomType
            txtBaord.EditValue = .Board
            txtDuration.EditValue = .Duration
            txtTransferTo.EditValue = .TransferTo
            txtTransferFrom.EditValue = .TransferFrom
            txtPax.EditValue = .Pax
            txtAdult.EditValue = .Adult
            txtChild.EditValue = .Child
            deImportDate.EditValue = .ImportDate
            txtIncomingAgency.EditValue = .IncomingAgency
            txtBookingStateDesc.EditValue = .BookingStateDesc
            txtUser.EditValue = .Username().Username

            'show log data
            txtPurchaseEUR.EditValue = .PurchaseEUR
            txtSalesEUR.EditValue = .SalesEUR
            txtMarginEUR.EditValue = .MarginEUR
            txtNetRateEUR.EditValue = .NetRateEUR
            txtDifferenceEUR.EditValue = .DifferenceEUR
            If .Junk Then txtJunk.EditValue = "YES" Else txtJunk.EditValue = "NO"
            If .Cancelled Then txtCancelled.EditValue = "YES" Else txtCancelled.EditValue = "NO"
            If .Excessive Then txtExcessive.EditValue = "YES" Else txtExcessive.EditValue = "NO"
            If .Mismatch Then txtMismatching.EditValue = "YES" Else txtMismatching.EditValue = "NO"
            If .WithError Then txtError.EditValue = "YES" Else txtError.EditValue = "NO"
            If .Negative Then txtNegative.EditValue = "YES" Else txtNegative.EditValue = "NO"

        End With

    End Sub
    Private Sub frmEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bookingsList.Count = 0 Then
            UpdateBooking()

            ' only check if user has the persmission to write the booking
            If GV.CurrentUser.Authority = "Amin" Or GV.CurrentUser.Authority = "MPI" Then
                Dim tempBooking As New Booking()
                tempBooking = GetDataSource(bookingId)

                If currentBooking.GetHashCode <> tempBooking.GetHashCode Then
                    Dim diaResult As DialogResult
                    diaResult = MessageBox.Show("Want to save changes to " & currentBooking.Reference & "?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
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
        Dim rowHandle As Integer = frmMain.GridView1.LocateByValue("BookingID", currentBooking.BookingID)
        If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            frmMain.GridView1.FocusedRowHandle = rowHandle
            'frmMain.UpdateCertainRow(rowHandle, currentBooking)
            frmMain.GridView1.SelectRow(rowHandle)
        End If
    End Sub

    Private Sub UpdateChangedRow()
        Dim rowHandle As Integer = frmMain.GridView1.LocateByValue("BookingID", currentBooking.BookingID)
        If rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            frmMain.UpdateCertainRow(rowHandle, currentBooking)
        End If
    End Sub

    Private Sub frmEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveCurrent()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.Wait(True)

        PopulateStatusMain()

        If bookingsList.Count = 0 Then
            currentBooking = GetDataSource(bookingId)
            ShowBooking()
            GetComments()
            LayoutControlGroup5.Visibility = Utils.LayoutVisibility.Always
            GridControl1.Visible = True
        Else
            LayoutControlGroup5.Visibility = Utils.LayoutVisibility.Never
            GridControl1.Visible = False
            labelControl.Text = "Multiple Bookings"
            GridControl1.DataSource = Nothing
        End If

        frmMain.Wait(False)
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
        If GV.CurrentUser.Authority = "Admin" Or GV.CurrentUser.Authority = "MPI" Then
            frmMain.Wait(True)
            UpdateBooking()
            If currentBooking.Save() Then
                currentBooking = GetDataSource(bookingId)
                ShowBooking()
                UpdateChangedRow()
            End If
            frmMain.Wait(False)
        End If
    End Sub
    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveCurrent()
        ElseIf e.Button.Properties.Caption = "Reset Changes" Then
            frmMain.Wait(True)
            currentBooking = GetDataSource(bookingId)
            ShowBooking()
            frmMain.Wait(False)
        ElseIf e.Button.Properties.Caption = "Close" Then
            Me.Close()
        ElseIf e.Button.Properties.Caption = "Mail" Then
            Dim subject, body As String
            

            subject = String.Format("Profitability Tool; Ref# {0} **{1}**",
                                    currentBooking.Reference, Today.ToString("dd.MM.yy"))
            body = String.Format("Dear {0}," & vbNewLine & vbNewLine & "Ref# {1}." & vbNewLine & "Please check this booking" _
                                 & vbNewLine & vbNewLine & "BR" & vbNewLine & "{2}",
                                 currentBooking.Username.FullName,
                                 currentBooking.Reference, GV.CurrentUser.FullName)

            SendMail.SetEmailSend(subject, body, currentBooking.Username.Mail, "")

        End If

    End Sub

    Private Sub btnToggleComment_Click(sender As Object, e As EventArgs) Handles btnToggleComment.Click
        If grpAddNewComment.Visibility = Utils.LayoutVisibility.Never Then
            grpAddNewComment.Visibility = Utils.LayoutVisibility.Always
            luStatus.Focus()
        Else
            grpAddNewComment.Visibility = Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub btnCancelComment_Click(sender As Object, e As EventArgs) Handles btnCancelComment.Click
        grpAddNewComment.Visibility = Utils.LayoutVisibility.Never
        ClearComment()
    End Sub

    Private Sub ClearComment()
        luStatus.EditValue = Nothing
        txtComment.EditValue = ""
        txtCalculation.EditValue = ""
    End Sub

    Private Sub btnSaveComment_Click(sender As Object, e As EventArgs) Handles btnSaveComment.Click
        If luStatus.EditValue Is Nothing Then
            MsgBox("Please enter status!")
            luStatus.Focus()
        ElseIf CStr(txtComment.EditValue) = "" Then
            MsgBox("please enter comment!")
            txtComment.Focus()
        Else
            frmMain.Wait(True)
            Dim comment = New Comment()
            comment.Status = CStr(luStatus.EditValue)
            comment.Comment = CStr(txtComment.EditValue)
            comment.BookingID = currentBooking.BookingID
            If CStr(txtCalculation.EditValue) = "" Then
                comment.Calculation = Nothing
            Else
                comment.Calculation = CSng(txtCalculation.EditValue)
            End If

            If bookingsList.Count = 0 Then
                If comment.Save() Then
                    GetComments()
                    UpdateBookingStatus(False, comment.Status, GV.CurrentUser.Username, comment.Comment, comment.Calculation)
                    grpAddNewComment.Visibility = Utils.LayoutVisibility.Never

                    ClearComment()
                End If
            Else
                If comment.SaveMulti(bookingsList) Then
                    UpdateBookingStatus(True, comment.Status, GV.CurrentUser.Username, comment.Comment, comment.Calculation)
                    grpAddNewComment.Visibility = Utils.LayoutVisibility.Never

                    ClearComment()
                    Me.Close()
                End If
            End If

            frmMain.Wait(False)
        End If
    End Sub

    Private Sub UpdateBookingStatus(ByVal multiple As Boolean, ByVal status As String, ByVal actionBy As String, ByVal comment As String, ByVal adjustedPrice As Double)

        currentBooking.Status = CStr(luStatus.EditValue)
        currentBooking.ActionBy = actionBy
        currentBooking.Comments = comment
        currentBooking.AdjustedPrice = CStr(adjustedPrice)
        If Not multiple Then
            frmMain.UpdateCertainRow(frmMain.GridView1.FocusedRowHandle, currentBooking)
        Else
            Dim withPrice As Boolean = adjustedPrice <> Nothing
            frmMain.UpdateCertainRow(withPrice, currentBooking)

        End If
    End Sub
    Private Sub txtComment_EditValueChanged(sender As Object, e As EventArgs) Handles txtComment.EditValueChanged
        Dim textCalc As Single = ExClass.CalculateText(CStr(txtComment.EditValue))
        If textCalc <> 0 Then
            txtCalculation.Text = textCalc.ToString
        End If
    End Sub

End Class
