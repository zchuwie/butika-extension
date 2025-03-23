Imports System.Net.Mail
Imports System.Net
Imports butika.Models

Namespace Services
    Public Class EmailVerification
        Private account As Account

        Public Sub New(acc As Account)
            Me.account = acc
        End Sub

        Public Async Function SendVerificationCodeForPassword() As Task(Of String)
            Dim random As New Random()
            Dim verificationCode As String = random.Next(100000, 999999).ToString()

            Dim message As New MailMessage()
            message.From = New MailAddress(Environment.GetEnvironmentVariable("BUTIKA_EMAIL"))
            message.To.Add(account.Email)
            message.Subject = "Your Verification Code"

            ' Well-formatted HTML email
            Dim emailBody As String = $"
            <html>
            <body style='font-family: Arial, sans-serif; line-height: 1.6;'>
                <h2 style='color: #333;'>Verification Code</h2>
                <p>Dear {account.UserName},</p>
                <p>Here is your verification code:</p>
                <p style='font-size: 24px; font-weight: bold; color: #16423C;'>{verificationCode}</p>
                <p>Please enter this code to reset your password. If you did not request this, please ignore this email.</p>
                <p>We hope you all the best, <br> Buti-ka </p>
            </body>
            </html>"

            message.Body = emailBody
            message.IsBodyHtml = True

            Dim smtpClient As New SmtpClient("smtp.gmail.com") With {
                .Port = 587,
                .Credentials = New NetworkCredential(Environment.GetEnvironmentVariable("BUTIKA_EMAIL"), Environment.GetEnvironmentVariable("BUTIKA_APP_PASS")),
                .EnableSsl = True
            }

            Try
                Await smtpClient.SendMailAsync(message)
                Console.WriteLine("Verification code sent successfully.")
                Return verificationCode
            Catch ex As Exception
                Console.WriteLine("Error sending email: " & ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace
