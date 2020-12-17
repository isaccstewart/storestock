Imports System.Net
Imports System.Net.Mail

Public Class test3
    Dim randomcode As String
    Public Shared touser As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rand As Random = New Random()
        randomcode = (rand.Next(999999)).ToString()
        touser = TextBox1.Text

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()

            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("funlearning.wisdom@gmail.com", "Qwerty@345")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("funlearning.wisdom@gmail.com")
            e_mail.To.Add(touser)
            e_mail.Subject = "!your re" + randomcode
            e_mail.IsBodyHtml = False
            e_mail.Body = "!your re" + randomcode
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
        'Dim from, pass, messagebody As String
        'Dim rand As Random = New Random()

        'randomcode = (rand.Next(999999)).ToString()
        'Dim message As MailMessage = New MailMessage()
        'touser = TextBox1.Text
        'from = "funlearning.wisdom@gmail.com"
        'pass = "Qwerty@345"
        'messagebody = "!your re" + randomcode
        'message.To.Add(touser)
        'message.From = New MailAddress(from)
        'message.Subject = "password code"
        'Dim smtp As SmtpClient = New SmtpClient("smtp.google.com") With {
        '  .EnableSsl = True,
        '   .Port = 587
        '}
        'smtp.DeliveryMethod = smtp.DeliveryMethod.Network
        'smtp.Credentials = New NetworkCredential(from, pass)
        'Try
        'smtp.Send(message)
        'MessageBox.Show("mail sent")
        'Catch ex As Exception
        ' MessageBox.Show(ex.Message)



        'End Try






    End Sub
End Class