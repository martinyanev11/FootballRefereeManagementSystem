namespace FootballRefereeManagementSystem.Services
{
    using SendGrid;
    using SendGrid.Helpers.Mail;

    using Contracts;

    public class EmailService : IEmailService
    {
        private readonly string apiKey;

        public EmailService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<bool> SendEmailAsync(string recipient, string subject, string content)
        {
            SendGridClient client = new SendGridClient(apiKey);

            EmailAddress fromEmail = new EmailAddress("sender", "Contact System"); // constant for test
            EmailAddress toEmail = new EmailAddress("reciever", "Test"); // constant for test
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
    }
}
