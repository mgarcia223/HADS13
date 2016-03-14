Imports System.Net.Mail

Public Class envioEmailConfirmacion

    Public Shared Function enviarEmail(ByVal email As String, ByVal url As String) As Boolean

        Dim message As New MailMessage
        Dim smtp As New SmtpClient

        'correo

        message.From = New MailAddress("hads13mm@gmail.com")
        message.To.Add(email)
        message.Body = url
        message.Subject = "Validacion de registro"
        message.Priority = MailPriority.Normal

        smtp.EnableSsl = True
        smtp.Port = "587"
        smtp.Host = "smtp.gmail.com"
        smtp.Credentials = New Net.NetworkCredential("hads13mm@gmail.com", "mikelmarta")
        smtp.Send(message)

        Return True
    End Function

End Class
