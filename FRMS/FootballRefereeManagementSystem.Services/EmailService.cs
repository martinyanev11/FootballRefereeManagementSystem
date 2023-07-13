﻿namespace FootballRefereeManagementSystem.Services
{
    using SendGrid;
    using SendGrid.Helpers.Mail;

    using Contracts;
    using Microsoft.Extensions.Configuration;
    using System.Text;

    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;
        private readonly string apiKey;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.apiKey = configuration["EmailSettings:ApiKey"];
        }

        public async Task<bool> SendEmailAsync(string recipient, string subject, string content)
        {
            SendGridClient client = new SendGridClient(apiKey);

            EmailAddress fromEmail = new EmailAddress(configuration["EmailSettings:ContactSystem:Email"], "NoReply");
            EmailAddress toEmail = new EmailAddress("bojejec943@meogl.com", "Test"); // random email for test
            string plainTextContent = content;
            string htmlContent = "";

            SendGridMessage? msg = MailHelper.CreateSingleEmail(fromEmail, toEmail, subject, plainTextContent, htmlContent);

            Response? response = await client.SendEmailAsync(msg);

            // Check the response status code
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                // Email sent successfully
                return true;
            }

            // If it reached here, an error occurred while sending the email
            return false;
        }

        public async Task<bool> SendEmailToContactSystemAsync(string firstName, string lastName, string email, string subject, string messageContent)
        {
            SendGridClient client = new SendGridClient(apiKey);

            string contactSystemEmail = configuration["EmailSettings:ContactSystem:Email"];
            string contactSystemName = configuration["EmailSettings:ContactSystem:Name"];
            EmailAddress senderEmail = new EmailAddress(contactSystemEmail, contactSystemName);

            // Sender and reciever are the same email address due to lack of Domain Authentication in SendGrid.
            // Just for development purposes. Has to be modified for production.
            EmailAddress recieverEmail = new EmailAddress(contactSystemEmail, "Sent by guest");

            string guestFullName = $"{firstName} {lastName}";
            string guestEmail = email;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{guestFullName} - ({guestEmail})\n");
            sb.AppendLine(messageContent);

            string plainTextContent = sb.ToString().TrimEnd();
            string htmlContent = "";

            SendGridMessage? msg = MailHelper.CreateSingleEmail(senderEmail, recieverEmail, subject, plainTextContent, htmlContent);

            Response? response = await client.SendEmailAsync(msg);

            // Check the response status code
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                // Email sent successfully
                return true;
            }

            // An error occurred while sending the email
            return false;
        }
    }
}
