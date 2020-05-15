Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office

Public Class SendMail

    Public Shared Sub SetEmailSend(sSubject As String, sBody As String, _
                         sTo As String, sCC As String)
        frmMain.Wait(True)

        Dim oApp As Interop.Outlook._Application
        oApp = New Interop.Outlook.Application

        Dim oMsg As Interop.Outlook._MailItem
        oMsg = CType(oApp.CreateItem(OlItemType.olMailItem), _MailItem)

        oMsg.Subject = sSubject
        oMsg.Body = sBody

        oMsg.To = sTo
        oMsg.CC = sCC

        frmMain.Wait(False)
        oMsg.Display(True)

    End Sub
End Class
