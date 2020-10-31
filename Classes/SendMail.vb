Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office

Public Class SendMail
    ''' <summary>
    ''' Send email from client Outlook
    ''' </summary>
    ''' <param name="sSubject"></param>
    ''' <param name="sBody"></param>
    ''' <param name="sTo"></param>
    ''' <param name="sCC"></param>
    Public Shared Sub SetEmailSend(sSubject As String, sBody As String, _
                         sTo As String, sCC As String)
        FrmMain.Wait(True)

        Dim oApp As Interop.Outlook._Application
        oApp = New Interop.Outlook.Application

        Dim oMsg As Interop.Outlook._MailItem
        oMsg = CType(oApp.CreateItem(OlItemType.olMailItem), _MailItem)

        oMsg.Subject = sSubject
        oMsg.Body = sBody

        oMsg.To = sTo
        oMsg.CC = sCC

        FrmMain.Wait(False)
        oMsg.Display(True)

    End Sub
End Class
