using BB_Common;
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

    public bool SendEmail(MailScenario scenario,string recipientEmail, string recipientName)
    {
        string subject;
        string body;

        switch (scenario)
        {
            case MailScenario.Welcome:
                subject = "Welcome to Budget Buddy, Bud!";
                body = $"Hello {recipientName},\n\nCongrats on creating your account! We are excited to help you manage your finances.";
                break;

                case MailScenario.AccountDelete:
                subject = "Action Required: Account Deletion Complete";
                body = $"Dear {recipientName},\n\nThis confirms your Budget Buddy account has been deleted.";
                break;

            default:
                Console.WriteLine("Error: Unknown scenario.");
                return false;
                
        }
        try
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Budget Buddy", "from@budgetbuddy.com"));
            email.To.Add(new MailboxAddress(recipientName, recipientEmail));
            email.Subject = subject;

            var bodyBuilder = new BodyBuilder
            {
                TextBody = body
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