namespace FootballRefereeManagementSystem.Services
{
    using Microsoft.Extensions.Options;
    using SendGrid.Helpers.Mail;
    using SendGrid;

    using Contracts;

    public class EmailService : IEmailService
    {
        private readonly SendGridClient _sendGridClient;

        public EmailService(IOptions<SendGridClientOptions> sendGridOptions)
        {
            string apiKey = sendGridOptions.Value.ApiKey;
            _sendGridClient = new SendGridClient(apiKey);
        }

        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            var fromEmail = new EmailAddress("marrtin@abv.bg", "Martin");
            var toEmailAddress = new EmailAddress(toEmail);

            var sendGridMessage = MailHelper.CreateSingleEmail(fromEmail, toEmailAddress, subject, message, message);
            await _sendGridClient.SendEmailAsync(sendGridMessage);
        }
    }
}
