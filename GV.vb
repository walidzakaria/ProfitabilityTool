Public Class GV
    Public Shared CurrentUser As New Login()
    Public Enum GwgStatus
        OK
        CAN
        OnR
        BNA
    End Enum

    Public Enum Status
        Matching
        Canceled
        PendingTO
        FixedTo
        PendingDMC
        FixedDMC
    End Enum

    Public Shared Function CIntGwgStatus(ByVal status As GwgStatus) As Integer
        Return CInt(status)


    End Function
End Class
