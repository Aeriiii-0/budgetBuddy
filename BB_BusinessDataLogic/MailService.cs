using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MailService
{
    private  string _smtpServer = "sandbox.smtp.mailtrap.io";
    private  int _port = 2525;
    private  string _username = "986926ff132db9";
    private  string _password = "80cf5104bdeefc";

    public bool SendWelcomeEmail(string recipientEmail, string recipientName)
    {
        try
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Budget Buddy", "from@example.com"));
            email.To.Add(new MailboxAddress(recipientName, recipientEmail));
            email.Subject = "Welcome to Budget Buddy!";

            var bodyBuilder = new BodyBuilder
            {
                TextBody = "Congrats on creating your account!"
            };
            email.Body = bodyBuilder.ToMessageBody();

            using var client = new SmtpClient();
            client.Connect(_smtpServer, _port, SecureSocketOptions.StartTlsWhenAvailable);
            client.Authenticate(_username, _password);
            client.Send(email);
            client.Disconnect(true);

            Console.WriteLine("Email sent successfully!");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending email: {ex.Message}");
            return false;
        }
    }
}