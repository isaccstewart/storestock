Imports System.Net
Imports System.Net.Mail

Public Class Form3
    Public Shared touser As String
    Dim randomcode As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rand As Random = New Random()
        randomcode = (rand.Next(999999)).ToString
        touser = TextBox1.Text
        Try
            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage()
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("funlearning.wisdom@gmail.com", "Qwerty@345")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("funlearning.wisdom@gmail.com")
            e_mail.To.Add(touser)
            e_mail.Subject = "recovery mail"
            e_mail.Body = "this is ur otp pls enter it in the applicaion " + randomcode
            smtp_server.Send(e_mail)
            MsgBox("mail sent")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try


    End Sub
End Class