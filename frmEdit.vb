Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraLayout.Helpers
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Partial Public Class frmEdit
    Public Shared bookingId As Long
    Dim currentBooking As New Booking()
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Function GetDataSource(ByVal bookingId As Long) As Booking
        'Dim result As New List(Of Booking)()
        Dim result As New Booking()
        result.BookingID = bookingId
        result.GetByID()
        
        Return result
    End Function

    Private Sub UpdateBooking()
        With currentBooking
            .HotelCode = txtHotelCode.EditValue
            .HotelName = txtHotelName.EditValue
            .CountryCode = txtCountry.EditValue
            .GwgStatus = txtGWGStatus.EditValue
            .PurchaseCurrency = txtPurchaseCurrency.EditValue
            .PurchasePrice = txtPurchasePrice.EditValue
            .SalesCurrency = txtSalesCurrency.EditValue
            .SalesPrice = txtSalesPrice.EditValue
            .GwgHandlingFee = txtHandlingFee.EditValue
            .Margin = txtMargin.EditValue
            .Difference = txtDifference.EditValue
            .CurrencyHotelTC = txtCurrencyHotelTc.EditValue
            .NetRateHotelTC = txtNetRateHotelTc.EditValue
            .NetRateHandlingTC = txtNetRateHandlingTc.EditValue
            .CheckHotel = txtHotelCheck.EditValue
            .CompanyGroup = txtCompanyGroup.EditValue
            .BookingDate = deBookingDate.EditValue
            .TravelDate = deTravelDate.EditValue
            .RoomType = txtRoomType.EditValue
            .Board = txtBaord.EditValue
            .Duration = txtDuration.EditValue
            .TransferTo = txtTransferTo.EditValue
            .TransferFrom = txtTransferFrom.EditValue
            .Pax = txtPax.EditValue
            .Adult = txtAdult.EditValue
            .Child = txtChild.EditValue
            .ImportDate = deImportDate.EditValue
            .IncomingAgency = txtIncomingAgency.EditValue
            .BookingStateDesc = txtBookingStateDesc.EditValue

        End With

    End Sub

    Private Sub frmEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SelectedCurrentRow()
    End Sub

    Private Sub ShowBooking()

        With currentBooking
            labelControl.Text = String.Format("Booking# <b><color=0, 0, 255>{0}</color></b>", .Reference)
            txtHotelCode.EditValue = .HotelCode
            txtHotelName.EditValue = .HotelName
            txtCountry.EditValue = .CountryCode
            txtGWGStatus.EditValue = .GwgStatus
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
        End With

    End Sub
    Private Sub frmEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UpdateBooking()
        Dim tempBooking As New Booking()
        tempBooking = GetDataSource(bookingId)

        If currentBooking.GetHashCode <> tempBooking.GetHashCode Then
            Dim diaResult As DialogResult
            diaResult = MessageBox.Show("Want to save changes to " & currentBooking.Reference & "?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If diaResult = Windows.Forms.DialogResult.Yes Then
                If currentBooking.Save() Then
                    UpdateChangedRow()
                End If
            ElseIf diaResult = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
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
            If currentBooking.Save() Then
                UpdateChangedRow()
            End If
        End If
    End Sub

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentBooking = GetDataSource(bookingId)
        ShowBooking()
        GetComments()
        'Dim dt As New DataTable()
        'dt.Columns.Add("ID")
        'dt.Columns.Add("Date")
        'dt.Columns.Add("LoginID")
        'dt.Columns.Add("Comment")
        'dt.Columns.Add("Calculation")
        'dt.Columns.Add("Status")

        'dt.Rows.Add({1, #1/1/2019#, "walid", "this sdfsdfsdsdfksjdkfjsjskdjfskldf sdfkjsdl;fksdj;sflkdjfs", 10.5, "OK"})
        'dt.Rows.Add({1, #1/1/2019#, "walid", "this sdfsdfsdsdfksjdkfjsjskdjfskldf sdfkjsdl;fksdj;sflkdjfs", 10.5, "Pending with TO"})
        'dt.Rows.Add({1, #1/1/2019#, "walid", "this sdfsdfsdsdfksjdkfjsjskdjfskldf sdfkjsdl;fksdj;sflkdjfs", 10.5, "Yes"})
        'dt.Rows.Add({1, #1/1/2019#, "walid", "this sdfsdfsdsdfksjdkfjsjskdjfskldf sdfkjsdl;fksdj;sflkdjfs", 10.5, "TO"})
        'dt.Rows.Add({1, #1/1/2019#, "walid", "this sdfsdfsdsdfksjdkfjsjskdjfskldf sdfkjsdl;fksdj;sflkdjfs", 10.5, "OK"})
        'dt.Rows.Add({1, #1/1/2019#, "walid", "this sdfsdfsdsdfksjdkfjsjskdjfskldf sdfkjsdl;fksdj;sflkdjfs", 10.5, "NA"})
        'GridControl1.DataSource = dt
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
        dt.Columns.Add("Status")

        MsgBox(dt.Columns(2).DataType.ToString)

        dt = ExClass.QueryGet(query)

        MsgBox(dt.Columns(2).DataType.ToString)
        GridControl1.DataSource = dt

    End Sub
    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            UpdateBooking()
            If currentBooking.Save() Then
                UpdateChangedRow()
                ShowBooking()
            End If

        ElseIf e.Button.Properties.Caption = "Reset Changes" Then
            currentBooking = GetDataSource(bookingId)
            ShowBooking()
        ElseIf e.Button.Properties.Caption = "Close" Then
            Me.Close()
        End If

    End Sub

    Private Sub btnToggleComment_Click(sender As Object, e As EventArgs) Handles btnToggleComment.Click
        If grpAddNewComment.Visibility = Utils.LayoutVisibility.Never Then
            grpAddNewComment.Visibility = Utils.LayoutVisibility.Always
            txtStatus.Focus()
        Else
            grpAddNewComment.Visibility = Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub btnCancelComment_Click(sender As Object, e As EventArgs) Handles btnCancelComment.Click
        grpAddNewComment.Visibility = Utils.LayoutVisibility.Never
        ClearComment()
    End Sub

    Private Sub ClearComment()
        txtStatus.EditValue = ""
        txtComment.EditValue = ""
        txtCalculation.EditValue = ""
    End Sub

    Private Sub btnSaveComment_Click(sender As Object, e As EventArgs) Handles btnSaveComment.Click
        If txtStatus.EditValue = "" Then
            MsgBox("Please enter status!")
            txtStatus.Focus()
        ElseIf txtComment.EditValue = "" Then
            MsgBox("please enter comment!")
            txtComment.Focus()
        ElseIf txtCalculation.EditValue = "" Then
            MsgBox("Please enter calculation!")
            txtCalculation.Focus()
        Else
            Dim comment = New Comment()
            comment.Status = txtStatus.EditValue
            comment.Comment = txtComment.EditValue
            comment.BookingID = currentBooking.BookingID
            comment.Calculation = Val(txtCalculation.Text)
            If comment.Save() Then
                GetComments()
                grpAddNewComment.Visibility = Utils.LayoutVisibility.Never
                ClearComment()
            End If

        End If
    End Sub
End Class
