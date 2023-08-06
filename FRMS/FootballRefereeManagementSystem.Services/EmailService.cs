namespace FootballRefereeManagementSystem.Services
{
    using System.Text;

    using SendGrid;
    using SendGrid.Helpers.Mail;

    using Microsoft.Extensions.Configuration;

    using Contracts;
    using Web.ViewModels.Career;
    using static FootballRefereeManagementSystem.Common.EmailConstants;

    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;
        private readonly string apiKey;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.apiKey = configuration["EmailSettings:ApiKey"];
        }

        public async Task<bool> SendApproveEmailToCareerCandidateAsync(ApplicationEmailModel emailModel)
        {
            SendGridClient client = new SendGridClient(apiKey);

            string careerSystemEmail = configuration["EmailSettings:ContactSystem:Email"];
            string careerSystemName = EmailCareerApproval.CareerSystemName;
            EmailAddress senderEmail = new EmailAddress(careerSystemEmail, careerSystemName);

            EmailAddress recieverEmail = new EmailAddress(emailModel.EmailAddress);

            string subject = EmailCareerApproval.Subject;
            string plainTextContent = 
                string.Format(EmailCareerApproval.PlainTextContent, emailModel.FullName, emailModel.Id, careerSystemName);

            string htmlContent = EmailCareerApproval.HtmlContent;

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

        public async Task<bool> SendDeclineEmailToCareerCandidateAsync(ApplicationEmailModel emailModel)
        {
            SendGridClient client = new SendGridClient(apiKey);

            string careerSystemEmail = configuration["EmailSettings:ContactSystem:Email"];
            string careerSystemName = EmailCareerDecline.CareerSystemName;
            EmailAddress senderEmail = new EmailAddress(careerSystemEmail, careerSystemName);

            EmailAddress recieverEmail = new EmailAddress(emailModel.EmailAddress);

            string subject = EmailCareerDecline.Subject;
            string plainTextContent = string.Format(EmailCareerDecline.PlainTextContent, emailModel.FullName, careerSystemName);

            string htmlContent = EmailCareerDecline.HtmlContent;

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

        public async Task<bool> SendEmailConfirmation(string newEmail, string subject, string plainTextContent, string htmlContent)
        {
            SendGridClient client = new SendGridClient(apiKey);

            string contactSystemEmail = configuration["EmailSettings:ContactSystem:Email"];
            string contactSystemName = configuration["EmailSettings:ContactSystem:Name"];
            EmailAddress senderEmail = new EmailAddress(contactSystemEmail, contactSystemName);

            EmailAddress recieverEmail = new EmailAddress(newEmail);

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
