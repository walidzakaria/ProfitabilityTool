Public Class frmUserSettings 
    Public Shared userId As Integer
    Private Sub LoadDestinations()
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM Destination ORDER BY Destination;"
        dt = ExClass.QueryGet(query)

        clbDestination.DataSource = dt
        clbDestination.DisplayMember = "DestinationCode"
        clbDestination.ValueMember = "DestinationID"

    End Sub

    Private Sub LoadOperators()
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM TourOperator ORDER BY TourOperator;"
        dt = ExClass.QueryGet(query)

        clbOperator.DataSource = dt
        clbOperator.DisplayMember = "TourOperator"
        clbOperator.ValueMember = "TourOperatorID"
    End Sub

    Private Sub LoadUserDestinations()
        Dim query As String = String.Format("SELECT DestinationCode" _
                                            & " FROM UserDestination, Destination" _
                                            & " WHERE UserDestination.DestinationID = Destination.DestinationId" _
                                            & " AND UserDestination.UserID = {0};", userId.ToString)
        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        clbDestination.UnCheckAll()

        Dim destination As String = ""
        For x = 0 To dt.Rows.Count - 1
            destination &= dt.Rows(x)(0).ToString & ";"
        Next
        Dim destinations() As String = destination.Split(";")
        For x = 0 To clbDestination.ItemCount - 1
            If destinations.Contains(clbDestination.GetDisplayItemValue(x)) Then
                clbDestination.SetItemChecked(x, True)
            End If
        Next

    End Sub

    Private Sub LoadUserOperators()
        Dim query As String = String.Format("SELECT TourOperator.TourOperator" _
                                            & " FROM UserOperator, TourOperator" _
                                            & " WHERE UserOperator.TourOperatorID = TourOperator.TourOperatorID" _
                                            & " AND UserOperator.UserID = {0};", userId.ToString)


        Dim dt As New DataTable()
        dt = ExClass.QueryGet(query)
        clbOperator.UnCheckAll()

        Dim tourOperator As String = ""
        For x = 0 To dt.Rows.Count - 1
            tourOperator &= dt.Rows(x)(0).ToString & ";"
        Next
        Dim tourOperators() As String = tourOperator.Split(";")
        For x = 0 To clbOperator.ItemCount - 1
            If tourOperators.Contains(clbOperator.GetDisplayItemValue(x)) Then
                clbOperator.SetItemChecked(x, True)
            End If
        Next
    End Sub

    Private Sub frmUserSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveSettings()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub
    Private Sub frmUserSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDestinations()
        LoadOperators()
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveSettings()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If

    End Sub

    Private Sub SaveSettings()
        Dim saveDestinations As Boolean = SaveUserDestinations()
        Dim saveOperators As Boolean = SaveUserOperators()
        If saveDestinations = saveOperators = True Then
            MsgBox("Settings saved successfully!")
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Failed to save!")
        End If

    End Sub

    Private Function SaveUserDestinations() As Boolean
        Dim result = False
        Dim destinationString As String = ""
        For Each item As Object In clbDestination.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            destinationString &= String.Format("({0}, {1}), ", userId.ToString, row("DestinationID"))
        Next
        If Not destinationString = "" Then
            destinationString = destinationString.TrimEnd
            destinationString = destinationString.TrimEnd(",")

            destinationString = String.Format("DELETE FROM UserDestination WHERE UserID = {0}; " _
                                              & "INSERT INTO UserDestination (UserID, DestinationID) VALUES {1};" _
                                              , userId.ToString, destinationString)

            result = ExClass.QuerySet(destinationString) = "True"
        Else
            destinationString = String.Format("DELETE FROM UserDestination WHERE UserID = {0};", userId.ToString)
            result = ExClass.QuerySet(destinationString) = "True"
        End If

        Return result
    End Function

    Private Function SaveUserOperators() As Boolean
        Dim result = False
        Dim operatorString As String = ""
        For Each item As Object In clbOperator.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            operatorString &= String.Format("({0}, {1}), ", userId.ToString, row("TourOperatorID"))
        Next
        If Not operatorString = "" Then
            operatorString = operatorString.TrimEnd
            operatorString = operatorString.TrimEnd(",")

            operatorString = String.Format("DELETE FROM UserOperator WHERE UserID = {0}; " _
                                              & "INSERT INTO UserOperator (UserID, TourOperatorID) VALUES {1};" _
                                              , userId.ToString, operatorString)

            result = ExClass.QuerySet(operatorString) = "True"
        Else
            operatorString = String.Format("DELETE FROM UserOperator WHERE UserID = {0}; ", userId.ToString)
            result = ExClass.QuerySet(operatorString) = "True"
        End If

        Return result
    End Function

    Private Sub frmUserSettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Application.DoEvents()
        LoadUserDestinations()
        LoadUserOperators()
    End Sub
End Class